using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwoleMate.Models
{
    public class WorkoutViewModel
    {
        public int WorkoutID { get; set; }
        public string Excercise1 { get; set; }
        public int ExcerciseReps1 { get; set; }
        public int ExcerciseSets1 { get; set; }
        public string Excercise2 { get; set; }
        public int ExcerciseReps2 { get; set; }
        public int ExcerciseSets2 { get; set; }
        public string Excercise3 { get; set; }
        public int ExcerciseReps3 { get; set; }
        public int ExcerciseSets3 { get; set; }
        public string Excercise4 { get; set; }
        public int ExcerciseReps4 { get; set; }
        public int ExcerciseSets4 { get; set; }
        public string Excercise5 { get; set; }
        public int ExcerciseReps5 { get; set; }
        public int ExcerciseSets5 { get; set; }
        public string WorkoutName { get; set; }
        public string DisplayExcercise1
        {
            get
            {
                return this.Excercise1 + ": " + this.ExcerciseSets1 + "x" + this.ExcerciseReps1;
            }
        }
        public string DisplayExcercise2
        {
            get
            {
                return this.Excercise2 + ": " + this.ExcerciseSets2 + "x" + this.ExcerciseReps2;
            }
        }
        public string DisplayExcercise3
        {
            get
            {
                return this.Excercise3 + ": " + this.ExcerciseSets3 + "x" + this.ExcerciseReps3;
            }
        }
        public string DisplayExcercise4
        {
            get
            {
                return this.Excercise4 + ": " + this.ExcerciseSets4 + "x" + this.ExcerciseReps4;
            }
        }
        public string DisplayExcercise5
        {
            get
            {
                return this.Excercise5 + ": " + this.ExcerciseSets5 + "x" + this.ExcerciseReps5;
            }
        }
    }
}
