using System;

public class UserReport : IReport
{
    public string Generate()
    {
        return "User Report:\n- User A (Active)\n- User B (Inactive)\n- User C (Active)\n";
    }
}
