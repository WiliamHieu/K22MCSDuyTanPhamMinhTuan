using System;

public class TutorialFormBase : DevExpress.XtraEditors.XtraForm
{
   private DevExpress.Utils.WaitDialogForm dlg = null;

   public void CreateWaitDialog()
   {
       dlg = new DevExpress.Utils.WaitDialogForm("Xin vui lòng chờ đợi", "Nhân ma trận");
   }

   public void SetWaitDialogCaption(string fCaption)
   {
       if (dlg != null)
       {
           dlg.Caption = fCaption;
       }
   }

   protected override void OnLoad(EventArgs e)
   {
       base.OnLoad(e);
       if (dlg != null)
           dlg.Close();
   }

   public void Exit()
   {
       if (dlg != null)
       {
           dlg.Close();
           dlg.Dispose();
       }
   }
}
