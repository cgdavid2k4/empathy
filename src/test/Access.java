import com.jacob.activeX.ActiveXComponent;
import com.jacob.com.ComThread;
import com.jacob.com.Dispatch;
import com.jacob.com.Variant;

class Access 
{
  public static void main(String[] args) throws Exception
  {
    ComThread.InitSTA();
    ActiveXComponent ax = new ActiveXComponent("DAO.PrivateDBEngine");
		// this only works for access files pre-access-2000
    Dispatch db = open(ax, ".\\sample2.mdb");
    String sql = "select * from MainTable";
    // make a temporary querydef
    Dispatch qd = Dispatch.call(db, "CreateQueryDef","").toDispatch();
    // set the SQL string on it
    Dispatch.put(qd, "SQL", sql);
    Variant result = getByQueryDef(qd);
		// the 2-d safearray is transposed from what you might expect
    System.out.println(result.toSafeArray());
    close(db);
		ComThread.Release();
  }

  /**
   * Open a database 
   */
  public static Dispatch open(ActiveXComponent ax, String fileName)
  {
    Variant f = new Variant(false);
    // open the file in read-only mode
    Variant[] args = new Variant[] {new Variant(fileName), f, f};
    Dispatch openDB = ax.invoke("OpenDatabase", args).toDispatch();
    return openDB;
  }

  /**
   * Close a database
   */
  public static void close(Dispatch openDB)
  {
    Dispatch.call(openDB, "Close");
  }

  /**
   * Extract the values from the recordset
   */
  public static Variant getValues(Dispatch recset)
  {
    Dispatch.callSub(recset,"moveFirst");
    Variant vi = new Variant(4096);
    Variant v = Dispatch.call(recset,"GetRows", vi);
    return v;
  }

  public static Variant getByQueryDef(Dispatch qd)
  {
    // get a reference to the recordset
    Dispatch recset = Dispatch.call(qd, "OpenRecordset").toDispatch();
    // get the values as a safe array
    String[] cols = getColumns(recset);
    for(int i=0;i<cols.length;i++)
    {
      System.out.print(cols[i]+" ");
    }
    System.out.println("");
    Variant vals = getValues(recset);
    return vals;
  }

  public static String[] getColumns(Dispatch recset)
  {
    Dispatch flds = Dispatch.get(recset, "Fields").toDispatch();
    int n_flds = Dispatch.get(flds, "Count").toInt();
    String[] s = new String[n_flds];
    Variant vi = new Variant();
    for (int i=0;i<n_flds;i++) {
      vi.putInt(i);
      // must use the invoke method because this is a method call
      // that wants to have a Dispatch.Get flag...
      Dispatch fld = Dispatch.invoke(recset, "Fields",
                       Dispatch.Get, new Object[] {vi}, new int[1]).toDispatch();
      Variant name = Dispatch.get(fld, "Name");
      s[i] = name.toString();
    }
    return s;
  }
}
