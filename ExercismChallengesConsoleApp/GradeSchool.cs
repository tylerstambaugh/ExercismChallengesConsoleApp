using System.Linq;
using System.Collections.Generic;

public class GradeSchool
{

    private Dictionary<string, int> RosterDict = new Dictionary<string, int>();

    public bool Add(string student, int grade)
    {
        if (RosterDict.ContainsKey(student))
            return false;
        else
        {
            RosterDict.Add(student, grade);
            return true;
        }

    }

    public IEnumerable<string> Roster()
    {
        return RosterDict.OrderBy(y => y.Key).OrderBy(x => x.Value).Select(x => x.Key);
    }

    public IEnumerable<string> Grade(int grade)
    {
        return RosterDict.Where(x => x.Value == grade).OrderBy(y => y.Key).Select(x => x.Key);
    }
}