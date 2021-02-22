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
    public partial class EditWorkout : System.Web.UI.Page
    {
        //Create a new instance of the business logic class for Workouts, we created the instance
        //here so that we can use it with both the Page_Load and Click event for WorkoutEditButton
        WorkoutBLL bll = new WorkoutBLL(ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString());
        /// <summary>
        /// Method for Load event to load values into the form for edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            //Only load the values if the request is not a PostBack
            if (!IsPostBack)
            {
                //We pass the WorkoutID by a Query String from the GridView on Workouts.aspx. See how we passed 
                //WorkoutID to this page from Workouts.aspx by looking at HyperLinkField in the GridView control
                //on the Workouts.aspx page for clarification
                WorkoutViewModel workout = bll.GetWorkoutById(Convert.ToInt32(Request.QueryString["WorkoutID"]));
                //We use the GetWorkoutById method to get the Workout from the database, which we use to 
                //populate the data into the form.
                Excercise1.Text = workout.Excercise1;
                ExcerciseReps1.Text = workout.ExcerciseReps1.ToString();
                ExcerciseSets1.Text = workout.ExcerciseSets1.ToString();
                Excercise2.Text = workout.Excercise2;
                ExcerciseReps2.Text = workout.ExcerciseReps2.ToString();
                ExcerciseSets2.Text = workout.ExcerciseSets2.ToString();
                Excercise3.Text = workout.Excercise3;
                ExcerciseReps3.Text = workout.ExcerciseReps3.ToString();
                ExcerciseSets3.Text = workout.ExcerciseSets3.ToString();
                Excercise4.Text = workout.Excercise4;
                ExcerciseReps4.Text = workout.ExcerciseReps4.ToString();
                ExcerciseSets4.Text = workout.ExcerciseSets4.ToString();
                Excercise5.Text = workout.Excercise5;
                ExcerciseReps5.Text = workout.ExcerciseReps5.ToString();
                ExcerciseSets5.Text = workout.ExcerciseSets5.ToString();
                WorkoutName.Text = workout.WorkoutName;
            }
        }

        protected void WorkoutEditButton_Click(object sender, EventArgs e)
        {
            //Check to see if all ValidationControls are valid
            if (Page.IsValid)
            {
                //Create new empty ViewModel to pass in the new values
                WorkoutViewModel workout = new WorkoutViewModel();
                //Use the same query string to fill the ID
                workout.WorkoutID = Convert.ToInt32(Request.QueryString["WorkoutID"]);
                workout.Excercise1 = Excercise1.Text;
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
                //Call the EditWorkout() method passing in the new values
                bll.EditWorkout(workout);
                //Redirect to the Workouts.aspx page
                Response.Redirect("~/Workouts.aspx");
            }
        }
    }
}