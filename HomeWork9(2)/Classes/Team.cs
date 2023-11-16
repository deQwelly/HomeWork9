using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9_2_.Classes
{
    public class Team
    {
        BigRaces.ParticipatingCountries country;
        List<string> members = new List<string>();

        public Team(BigRaces.ParticipatingCountries country, string m1, string m2, string m3, string m4, string m5,
            string m6, string m7, string m8, string m9, string m10, string m11, string m12, string m13, string m14, string m15)
        {
            this.country = country;
            members.Add(m1);
            members.Add(m2);
            members.Add(m3);
            members.Add(m4);
            members.Add(m5);
            members.Add(m6);
            members.Add(m7);
            members.Add(m8);
            members.Add(m9);
            members.Add(m10);
            members.Add(m11);
            members.Add(m12);
            members.Add(m13);
            members.Add(m14);
            members.Add(m15);
        }

        public BigRaces.ParticipatingCountries Counrty 
        {
            get
            {
                return country;
            }
        }

        public string ShowTeamMembers()
        {
            string showMembers = "";
            foreach (string member in members)
            {
                showMembers += member + ", ";
            }
            return country + ": " + showMembers.Substring(0, showMembers.Length - 2);
        }
    }
}
