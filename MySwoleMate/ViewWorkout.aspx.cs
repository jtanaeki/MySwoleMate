using MySwoleMate.BLL;
using MySwoleMate.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySwoleMate
{
    public partial class ViewWorkout : System.Web.UI.Page
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString();
        TraineeBLL tBll = new TraineeBLL(connectionString);
        WorkoutBLL wBll = new WorkoutBLL(connectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TraineeViewModel trainee = tBll.GetTraineeById(Convert.ToInt32(Request.QueryString["TraineeID"]));
                WorkoutViewModel workout = wBll.GetWorkoutById(trainee.WorkoutID);

                FirstName.Text = trainee.FirstName;
                LastName.Text = trainee.LastName;

                WorkoutName.Text = workout.WorkoutName;

                DisplayExcercise1.Text = workout.DisplayExcercise1;
                DisplayExcercise2.Text = workout.DisplayExcercise2;
                DisplayExcercise3.Text = workout.DisplayExcercise3;
                DisplayExcercise4.Text = workout.DisplayExcercise4;
                DisplayExcercise5.Text = workout.DisplayExcercise5;
            }
        }

        protected void AssignWorkoutButton_Click(object sender, EventArgs e)
        {
            //Check to see if all ValidationControls are valid
            if (Page.IsValid)
            {
                //Redirect to the AssignWorkout.aspx page
                Response.Redirect("~/AssignWorkout.aspx?TraineeID=" + Request.QueryString["TraineeID"]);
            }
        }
    }
}