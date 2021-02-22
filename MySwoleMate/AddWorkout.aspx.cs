using MySwoleMate.BLL;
using MySwoleMate.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySwoleMate
{
    public partial class AddWorkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Add Workout to DB from user input form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void WorkoutAddButton_Click(object sender, EventArgs e)
        {
            //Checks to see if all Validation Controls are valid
            if (Page.IsValid)
            {
                //Grab connectionString from web.config file
                string connectionString = ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString();
                //Create new instance of WorkoutBLL
                WorkoutBLL bll = new WorkoutBLL(connectionString);
                //Create new instance of ViewModel with data from the user
                WorkoutViewModel workout = new WorkoutViewModel();
                //The Text property of each control will contain the data from the user
                workout.Excercise1 = Excercise1.Text;
                //Since the Text property returns a string, some properties would need to be converted
                workout.ExcerciseReps1 = Convert.ToInt32(ExcerciseReps1.Text);
                workout.ExcerciseSets1 = Convert.ToInt32(ExcerciseSets1.Text);
                workout.Excercise2 = Excercise2.Text;
                workout.ExcerciseReps2 = Convert.ToInt32(ExcerciseReps2.Text);
                workout.ExcerciseSets2 = Convert.ToInt32(ExcerciseSets2.Text);
                workout.Excercise3 = Excercise3.Text;
                workout.ExcerciseReps3 = Convert.ToInt32(ExcerciseReps3.Text);
                workout.ExcerciseSets3 = Convert.ToInt32(ExcerciseSets3.Text);
                workout.Excercise4 = Excercise4.Text;
                workout.ExcerciseReps4 = Convert.ToInt32(ExcerciseReps4.Text);
                workout.ExcerciseSets4 = Convert.ToInt32(ExcerciseSets4.Text);
                workout.Excercise5 = Excercise5.Text;
                workout.ExcerciseReps5 = Convert.ToInt32(ExcerciseReps5.Text);
                workout.ExcerciseSets5 = Convert.ToInt32(ExcerciseSets5.Text);
                workout.WorkoutName = WorkoutName.Text;
                //Call the Business Logic method to add workout
                bll.AddWorkout(workout);
                //Return to the Workouts list after adding the workout to database
                Response.Redirect("~/Workouts.aspx");
            }
        }
    }
}