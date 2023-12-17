namespace Parser.Model
{
    public enum UserRole
    {
        Administrator = 0, // read/edit/delete/addUsers
        Employee = 1, // read/edit/delete
        Auditor = 2 // read
    }
}
