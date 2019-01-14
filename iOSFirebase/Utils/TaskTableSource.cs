using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

namespace iOSFirebase.Utils
{
    public class TaskTableSource : UITableViewSource
    {
        string[] TableItems;
        string CellIdentifier = "TableCell";

        public TaskTableSource(string[] items)
        {
            TableItems = items;
        }

        public TaskTableSource(List<Utils.Task> tasks)
        {
            TableItems = tasks.Select(x => x.description + " " + x.createdDate).ToArray();
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return TableItems.Length;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
            string item = TableItems[indexPath.Row];

            //---- if there are no cells to reuse, create a new one
            if (cell == null)
            { cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier); }

            cell.TextLabel.Text = item;

            return cell;
        }
    }
}

