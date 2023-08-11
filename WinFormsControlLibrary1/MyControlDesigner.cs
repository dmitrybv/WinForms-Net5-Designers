using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace WinFormsControlLibrary1
{
  internal class MyControlDesigner : ControlDesigner
  {
    private DesignerActionListCollection actionLists;

    public override DesignerActionListCollection ActionLists
    {
      get
      {
        if (actionLists == null)
        {
          actionLists = new DesignerActionListCollection();
          actionLists.Add(new DataAxisGridActionList(Component));
          actionLists.AddRange(base.ActionLists);
        }
        return actionLists;
      }
    }
  }

  public class DataAxisGridActionList : DesignerActionList
  {

    public DataAxisGridActionList(IComponent component) : base(component)
    {
    }

    public override DesignerActionItemCollection GetSortedActionItems()
    {
      DesignerActionItemCollection items = new DesignerActionItemCollection();
      items.Add(new DesignerActionMethodItem(this, "Action1", " Action 1", true));
      items.Add(new DesignerActionMethodItem(this, "Action2", "Action 2", true));
      return items;
    }

    public void Action1()
    {
      MessageBox.Show("Action 1");
    }

    public void Action2()
    {
      MessageBox.Show("Action 2");
    }
  }

}
