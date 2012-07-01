import com.jacob.activeX.ActiveXComponent;
import com.jacob.com.Dispatch;
import com.jacob.com.DispatchEvents;
import com.jacob.com.Variant;

class IETest
{
    public static void main(String[] args)
    {
      ActiveXComponent ie = new ActiveXComponent("clsid:0002DF01-0000-0000-C000-000000000046");
      Object ieo = ie.getObject();
      try {
        Dispatch.put(ieo, "Visible", new Variant(true));
        Dispatch.put(ieo, "AddressBar", new Variant(true));
        System.out.println(Dispatch.get(ieo, "Path"));
        Dispatch.put(ieo, "StatusText", new Variant("My Status Text"));
  
        IEEvents ieE = new IEEvents();
        DispatchEvents de = new DispatchEvents((Dispatch) ieo, ieE,"InternetExplorer.Application.1");
        Variant optional = new Variant();
        optional.noParam();
  
        Dispatch.call(ieo, "Navigate", new Variant("http://www.danadler.com/jacob"));
        try { Thread.sleep(5000); } catch (Exception e) {}
        Dispatch.call(ieo, "Navigate", new Variant("http://groups.yahoo.com/group/jacob-project"));
        try { Thread.sleep(5000); } catch (Exception e) {}
      } catch (Exception e) {
        e.printStackTrace();
      } finally {
        ie.invoke("Quit", new Variant[] {});
      }
    }
}

class IEEvents 
{
    public void BeforeNavigate2(Variant[] args) {
      System.out.println("BeforeNavigate2");
    }

    public void CommandStateChanged(Variant[] args) {
      System.out.println("CommandStateChanged");
    }

    public void DocumentComplete(Variant[] args) {
      System.out.println("DocumentComplete");
    }

    public void DownloadBegin(Variant[] args) {
      System.out.println("DownloadBegin");
    }

    public void DownloadComplete(Variant[] args) {
      System.out.println("DownloadComplete");
    }

    public void NavigateComplete2(Variant[] args) {
      System.out.println("NavigateComplete2");
    }

    public void NewWindow2(Variant[] args) {
      System.out.println("NewWindow2");
    }

    public void OnFullScreen(Variant[] args) {
      System.out.println("OnFullScreen");
    }

    public void OnMenuBar(Variant[] args) {
      System.out.println("OnMenuBar");
    }

    public void OnQuit(Variant[] args) {
      System.out.println("OnQuit");
    }

    public void OnStatusBar(Variant[] args) {
      System.out.println("OnStatusBar");
    }

    public void OnTheaterMode(Variant[] args) {
      System.out.println("OnTheaterMode");
    }

    public void OnToolBar(Variant[] args) {
      System.out.println("OnToolBar");
    }

    public void OnVisible(Variant[] args) {
      System.out.println("OnVisible");
    }

    public void ProgressChange(Variant[] args) {
      System.out.println("ProgressChange");
    }

    public void PropertyChange(Variant[] args) {
      System.out.println("PropertyChange");
    }

    public void StatusTextChange(Variant[] args) {
      System.out.println("StatusTextChange");
    }

    public void TitleChange(Variant[] args) {
      System.out.println("TitleChange");
    }
}
