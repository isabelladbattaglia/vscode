// See https://aka.ms/new-console-template for more information

static string MyMethod(string fname, string lname)

{
    //Console.WriteLine(fname + "Michael" + "Samantha" + "Joshua" + "Isabella" + "Evan" + lname + " Battaglia" );
    string fullName = fname + " " + lname;
    return (fullName);
}
MyMethod("Michael", "Battaglia" );
MyMethod("Samantha", "Battaglia");
MyMethod("Joshua", "Battaglia");
MyMethod("Kristin", "Battaglia");
MyMethod("Isabella", "Battaglia");
MyMethod("Evan", "Battaglia");


Console.WriteLine(MyMethod("Michael", "Battaglia"));
Console.WriteLine(MyMethod("Kristin", "Battaglia"));
Console.WriteLine(MyMethod("Isabella", "Battaglia"));
Console.WriteLine(MyMethod("Joshua", "Battaglia"));
Console.WriteLine(MyMethod("Samantha", "Battaglia"));
Console.WriteLine(MyMethod("Evan", "Battaglia"));