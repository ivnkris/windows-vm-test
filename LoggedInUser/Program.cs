string userName;
try
{
    userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
    Console.WriteLine(userName);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}