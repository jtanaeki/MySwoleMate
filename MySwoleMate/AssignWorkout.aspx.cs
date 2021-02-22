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
    public partial class AssignWorkout : System.Web.UI.Page
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString();
        TraineeBLL bll = new TraineeBLL(connectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();

                TraineeViewModel trainee = bll.GetTraineeById(Convert.ToInt32(Request.QueryString["TraineeID"]));

                FirstName.Text = trainee.FirstName;
                LastName.Text = trainee.LastName;

                WorkoutList.Items.Insert(0, new ListItem("   --  Select  --   ", "0"));
                WorkoutList.SelectedValue = trainee.WorkoutID.ToString();
            }
        }

        protected void WorkoutAssignButton_Click(object sender, EventArgs e)
        {
            //Check to see if all ValidationControls are valid
            if (Page.IsValid)
            {
                //Create new empty ViewModel to pass in the new values
                TraineeViewModel trainee = new TraineeViewModel();
                //Use the same query string to fill the ID
                trainee.TraineeID = Convert.ToInt32(Request.QueryString["TraineeID"]);
                trainee.WorkoutID = Convert.ToInt32(WorkoutList.SelectedValue);
                //Call the AssignTrainee() method passing in the new values
                bll.AssignTrainee(trainee);
                //Redirect to the Trainees.aspx page
                Response.Redirect("~/Trainees.aspx");
            }
        }

        private void BindData()
        {
            WorkoutBLL bll = new WorkoutBLL(connectionString);
            WorkoutList.DataSource = bll.GetAllWorkouts();
            WorkoutList.DataTextField = "WorkoutName";
            WorkoutList.DataValueField = "WorkoutID";
            WorkoutList.DataBind();
        }
    }
}
