using System.Dynamic;

public static class Utils{
    public static dynamic getStuff(){
        dynamic rtn = new ExpandoObject();
        rtn.stuff = "this is stuff";
        return rtn;
    }
}