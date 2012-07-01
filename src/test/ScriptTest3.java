import com.jacob.com.*;
import com.jacob.activeX.*;

/**
 * Here we create the ScriptControl component in a separate MTA thread
 * and then call the Eval method from the main thread. The main thread
 * must also be an MTA thread. If you try to create it as an STA
 * then you will not be able to make calls into a component running
 * in another thread.
 */
class ScriptTest3 extends Thread
{
  public static ActiveXComponent sC;
  public static DispatchEvents de = null;
  public static Dispatch sControl = null;
  public static boolean quit = false;

  public void run()
  {
     try
     {
       ComThread.InitMTA();
       System.out.println("OnInit");
       String lang = "VBScript";
       sC = new ActiveXComponent("ScriptControl");
       sControl = (Dispatch)sC.getObject();
       Dispatch.put(sControl, "Language", lang);
       errEvents te = new errEvents();
       de = new DispatchEvents(sControl, te);
       System.out.println("sControl="+sControl);
       while (!quit) sleep(100);
       ComThread.Release();
     }
     catch (Exception e)
     {
       e.printStackTrace();
     }
     finally
     {
       System.out.println("worker thread exits");
     }
  }

  public static void main(String args[]) throws Exception
  {
    try {
      ComThread.InitMTA();
      ScriptTest3 script = new ScriptTest3();
      script.start();
      Thread.sleep(1000);

      Variant result = Dispatch.call(sControl, "Eval", args[0]);
      System.out.println("eval("+args[0]+") = "+ result);
      System.out.println("setting quit");
      script.quit = true;
    } catch (ComException e) {
      e.printStackTrace();
    }
    finally
    {
      System.out.println("main done");
      ComThread.Release();
    }
  }
}

class errEvents {
  public void Error(Variant[] args)
  {
    System.out.println("java callback for error!");
  }
  public void Timeout(Variant[] args)
  {
    System.out.println("java callback for error!");
  }
}
