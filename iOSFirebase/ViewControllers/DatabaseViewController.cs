using System;
using System.Collections.Generic;
using System.Linq;
using Firebase.Database;
using Foundation;
using iOSFirebase.Utils;
using UIKit;

namespace iOSFirebase.ViewControllers
{
    public partial class DatabaseViewController : UIViewController
    {
        public DatabaseViewController(IntPtr handle) : base(handle)
        {
        }

        Database databaseInstance;
        DatabaseReference dbReference;
        NSString folder = new NSString("tasks");

        List<Utils.Task> tasks;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            tasks = new List<Utils.Task>();

            //string[] tableItems = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };
            //tasksTableView.Source = new TaskTableSource(tableItems);

            databaseInstance = Firebase.Database.Database.DefaultInstance;

            dbReference = databaseInstance.GetRootReference().GetChild(folder);

            dbReference.ObserveEvent(DataEventType.Value, HandleDatabaseQueryUpdateHandler);

            dbReference.ObserveEvent(DataEventType.ChildAdded, HandleDatabaseQueryUpdateHandler);
        }

        void HandleDatabaseQueryUpdateHandler(DataSnapshot snapshot)
        {
            tasks = new List<Utils.Task>();
            if (snapshot == null)
            {
                ToastIOS.Toast.MakeText("An Error occured reading data").Show();
                return;
            }

            try
            {
                var values = snapshot.GetValue<NSDictionary<NSString, NSString>>();

                foreach (var taskDict in values)
                {
                    var key = taskDict.Key;
                    var keyValue = taskDict.Value;


                    var dictValue = (NSDictionary)keyValue;

                    var task = new Utils.Task();
                    task.Id = dictValue["Id"].ToString();
                    task.description = dictValue["Description"].ToString();
                    task.createdDate = dictValue["CreatedDate"].ToString();
                    tasks.Add(task);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: ", ex.Message);
            }
            tasksTableView.Source = new TaskTableSource(tasks);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        void AddTask(string input)
        {

        }

        partial void AddButton_TouchUpInside(UIButton sender)
        {
            Utils.Task task = new Utils.Task();

            task.Id = Guid.NewGuid().ToString();
            task.description = taskInputText.Text;
            task.createdDate = DateTime.Now.ToString();

            NSString text = new NSString(task.description);
            var child = dbReference.GetChild(task.Id);
            child.SetValue<NSString>(text);

            var iconattrs = new Dictionary<string, string>
                {
                {"Id", task.Id},
                {"Description", task.description},
                {"CreatedDate", task.createdDate}
                };

            var myResult = NSDictionary.FromObjectsAndKeys(iconattrs.Values.ToArray()
                                                           , iconattrs.Keys.ToArray());

            child.SetValue<NSDictionary>(myResult);
        }
    }
}

