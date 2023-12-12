try
{
    using (var searcher = new System.Management.ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
    {
        using (var items = searcher.Get())
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}