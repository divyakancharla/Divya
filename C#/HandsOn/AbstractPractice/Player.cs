using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPractice
{
   abstract class Player
    {
        protected string name;
        protected string teamname;
        protected int noofmatches;
        public Player(string name, string teamname, int noofmatches)
        {
            Console.ReadLine();
            this.name = name;
            this.teamname = teamname;
            this.noofmatches = noofmatches;
        }
        public abstract void display();

    }
    class CricketPlayer : Player
    {
        int totalRunsScored, noOfWicketstaken;
        
        public CricketPlayer(string name,string teamname,int noofmatches,int totalRunsScored,int  noOfWicketstaken):base(name,teamname,noofmatches)
        {
            this.totalRunsScored = totalRunsScored;
            this.noOfWicketstaken = noOfWicketstaken;
        }
        public override void display()
        {
            Console.WriteLine(this.name + "\n" + this.teamname + "\n" + this.noofmatches + "\n" + this.totalRunsScored + "\n" + this.noOfWicketstaken + "\n");
        }

    }
    class HockeyPlayer : Player
    {
        string position;
        int noOfGoals;
        public HockeyPlayer(string name, string teamname, int noofmatches,string p,int nog):base(name, teamname, noofmatches)
        {
            this.position = p;
            this.noOfGoals = nog;
        }
        public override void display()
        {
            Console.WriteLine(this.name+"\n" + this.teamname + "\n" + this.noofmatches + "\n" + this.position + "\n" + this.noOfGoals);
        }
    }
}
