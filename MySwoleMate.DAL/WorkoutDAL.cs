using MySwoleMate.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwoleMate.DAL
{
    //DAL stands for Data Access Layer. Data Access Layer is the layer which communicates to the database.
    public class WorkoutDAL
    {
        //uses connection string for connecting to database
        private string _connectionString;
        public WorkoutDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        //Returns All Workouts
        public List<WorkoutViewModel> GetWorkouts()
        {
            //SQL command for selecting all from Workout table
            string sqlQuery = "SELECT * FROM Workouts";

            //Empty list of WorkoutViewModel to add and return
            List<WorkoutViewModel> workouts = new List<WorkoutViewModel>();

            //Using SqlConnection to establish connection to database
            //using SqlCommand passing in the SqlConnection and the sqlQuery
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                //open the connection
                con.Open();
                //SqlDataReader is used because we are reading data from the database
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    //while there are records in the database
                    while (reader.Read())
                    {
                        //store each value into the properties of WorkoutViewModel
                        WorkoutViewModel temp = new WorkoutViewModel()
                        {
                            WorkoutID = Convert.ToInt32(reader["WorkoutID"]),
                            Excercise1 = reader["Excercise1"].ToString(),
                            ExcerciseReps1 = Convert.ToInt32(reader["ExcerciseReps1"]),
                            ExcerciseSets1 = Convert.ToInt32(reader["ExcerciseSets1"]),
                            Excercise2 = reader["Excercise2"].ToString(),
                            ExcerciseReps2 = Convert.ToInt32(reader["ExcerciseReps2"]),
                            ExcerciseSets2 = Convert.ToInt32(reader["ExcerciseSets2"]),
                            Excercise3 = reader["Excercise3"].ToString(),
                            ExcerciseReps3 = Convert.ToInt32(reader["ExcerciseReps3"]),
                            ExcerciseSets3 = Convert.ToInt32(reader["ExcerciseSets3"]),
                            Excercise4 = reader["Excercise4"].ToString(),
                            ExcerciseReps4 = Convert.ToInt32(reader["ExcerciseReps4"]),
                            ExcerciseSets4 = Convert.ToInt32(reader["ExcerciseSets4"]),
                            Excercise5 = reader["Excercise5"].ToString(),
                            ExcerciseReps5 = Convert.ToInt32(reader["ExcerciseReps5"]),
                            ExcerciseSets5 = Convert.ToInt32(reader["ExcerciseSets5"]),
                            WorkoutName = reader["WorkoutName"].ToString(),
                        };
                        //Add the Workout object to the List of Workout
                        workouts.Add(temp);
                    }
                }
            }
            return workouts;
        }

        //Get Workout By Id, returns one instance of WorkoutViewModel
        //Very similar to GetWorkouts() method above
        public WorkoutViewModel GetWorkoutById(int id)
        {
            WorkoutViewModel workout = new WorkoutViewModel();
            string sqlQuery = "SELECT * FROM Workouts where WorkoutId=@ID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        workout.WorkoutID = Convert.ToInt32(reader["WorkoutID"]);
                        workout.Excercise1 = reader["Excercise1"].ToString();
                        workout.ExcerciseReps1 = Convert.ToInt32(reader["ExcerciseReps1"]);
                        workout.ExcerciseSets1 = Convert.ToInt32(reader["ExcerciseSets1"]);
                        workout.Excercise2 = reader["Excercise2"].ToString();
                        workout.ExcerciseReps2 = Convert.ToInt32(reader["ExcerciseReps2"]);
                        workout.ExcerciseSets2 = Convert.ToInt32(reader["ExcerciseSets2"]);
                        workout.Excercise3 = reader["Excercise3"].ToString();
                        workout.ExcerciseReps3 = Convert.ToInt32(reader["ExcerciseReps3"]);
                        workout.ExcerciseSets3 = Convert.ToInt32(reader["ExcerciseSets3"]);
                        workout.Excercise4 = reader["Excercise4"].ToString();
                        workout.ExcerciseReps4 = Convert.ToInt32(reader["ExcerciseReps4"]);
                        workout.ExcerciseSets4 = Convert.ToInt32(reader["ExcerciseSets4"]);
                        workout.Excercise5 = reader["Excercise5"].ToString();
                        workout.ExcerciseReps5 = Convert.ToInt32(reader["ExcerciseReps5"]);
                        workout.ExcerciseSets5 = Convert.ToInt32(reader["ExcerciseSets5"]);
                        workout.WorkoutName = reader["WorkoutName"].ToString();
                    }
                }
            }
            return workout;
        }

        //Edits Workout using "UPDATE" Sql Query passing in values to edit depending on the WorkoutID
        public int EditWorkout(WorkoutViewModel edit)
        {
            string sqlQuery = "UPDATE Workouts SET Excercise1=@Excercise1, ExcerciseReps1=@ExcerciseReps1, " +
                "ExcerciseSets1=@ExcerciseSets1, Excercise2=@Excercise2, ExcerciseReps2=@ExcerciseReps2, " +
                "ExcerciseSets2=@ExcerciseSets2, Excercise3=@Excercise3, ExcerciseReps3=@ExcerciseReps3, " +
                "ExcerciseSets3=@ExcerciseSets3, Excercise4=@Excercise4, ExcerciseReps4=@ExcerciseReps4, " +
                "ExcerciseSets4=@ExcerciseSets4, Excercise5=@Excercise5, ExcerciseReps5=@ExcerciseReps5, " +
                "ExcerciseSets5=@ExcerciseSets5, WorkoutName=@WorkoutName WHERE WorkoutID=@ID";

            //No need to use SqlDataReader here since we are just using the Sql Query to persist to database
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = edit.WorkoutID;
                cmd.Parameters.Add("@Excercise1", SqlDbType.VarChar).Value = edit.Excercise1;
                cmd.Parameters.Add("@ExcerciseReps1", SqlDbType.Int).Value = edit.ExcerciseReps1;
                cmd.Parameters.Add("@ExcerciseSets1", SqlDbType.Int).Value = edit.ExcerciseSets1;
                cmd.Parameters.Add("@Excercise2", SqlDbType.VarChar).Value = edit.Excercise2;
                cmd.Parameters.Add("@ExcerciseReps2", SqlDbType.Int).Value = edit.ExcerciseReps2;
                cmd.Parameters.Add("@ExcerciseSets2", SqlDbType.Int).Value = edit.ExcerciseSets2;
                cmd.Parameters.Add("@Excercise3", SqlDbType.VarChar).Value = edit.Excercise3;
                cmd.Parameters.Add("@ExcerciseReps3", SqlDbType.Int).Value = edit.ExcerciseReps3;
                cmd.Parameters.Add("@ExcerciseSets3", SqlDbType.Int).Value = edit.ExcerciseSets3;
                cmd.Parameters.Add("@Excercise4", SqlDbType.VarChar).Value = edit.Excercise4;
                cmd.Parameters.Add("@ExcerciseReps4", SqlDbType.Int).Value = edit.ExcerciseReps4;
                cmd.Parameters.Add("@ExcerciseSets4", SqlDbType.Int).Value = edit.ExcerciseSets4;
                cmd.Parameters.Add("@Excercise5", SqlDbType.VarChar).Value = edit.Excercise5;
                cmd.Parameters.Add("@ExcerciseReps5", SqlDbType.Int).Value = edit.ExcerciseReps5;
                cmd.Parameters.Add("@ExcerciseSets5", SqlDbType.Int).Value = edit.ExcerciseSets5;
                cmd.Parameters.Add("@WorkoutName", SqlDbType.VarChar).Value = edit.WorkoutName;
                return cmd.ExecuteNonQuery();
            }
        }

        //Add Workout using "INSERT" Sql Query depending on the values, very similar to EditWorkout
        //method above
        public int AddWorkout(WorkoutViewModel add)
        {
            string sqlQuery = "INSERT into Workouts (Excercise1, ExcerciseReps1, ExcerciseSets1, " +
                "Excercise2, ExcerciseReps2, ExcerciseSets2, Excercise3, ExcerciseReps3, ExcerciseSets3, " +
                "Excercise4, ExcerciseReps4, ExcerciseSets4, Excercise5, ExcerciseReps5, ExcerciseSets5, WorkoutName" +
                ") VALUES (@Excercise1, @ExcerciseReps1, @ExcerciseSets1, @Excercise2, @ExcerciseReps2, @ExcerciseSets2, " +
                "@Excercise3, @ExcerciseReps3, @ExcerciseSets3, @Excercise4, @ExcerciseReps4, @ExcerciseSets4, " +
                "@Excercise5, @ExcerciseReps5, @ExcerciseSets5, @WorkoutName)";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@Excercise1", SqlDbType.VarChar).Value = add.Excercise1;
                cmd.Parameters.Add("@ExcerciseReps1", SqlDbType.Int).Value = add.ExcerciseReps1;
                cmd.Parameters.Add("@ExcerciseSets1", SqlDbType.Int).Value = add.ExcerciseSets1;
                cmd.Parameters.Add("@Excercise2", SqlDbType.VarChar).Value = add.Excercise2;
                cmd.Parameters.Add("@ExcerciseReps2", SqlDbType.Int).Value = add.ExcerciseReps2;
                cmd.Parameters.Add("@ExcerciseSets2", SqlDbType.Int).Value = add.ExcerciseSets2;
                cmd.Parameters.Add("@Excercise3", SqlDbType.VarChar).Value = add.Excercise3;
                cmd.Parameters.Add("@ExcerciseReps3", SqlDbType.Int).Value = add.ExcerciseReps3;
                cmd.Parameters.Add("@ExcerciseSets3", SqlDbType.Int).Value = add.ExcerciseSets3;
                cmd.Parameters.Add("@Excercise4", SqlDbType.VarChar).Value = add.Excercise4;
                cmd.Parameters.Add("@ExcerciseReps4", SqlDbType.Int).Value = add.ExcerciseReps4;
                cmd.Parameters.Add("@ExcerciseSets4", SqlDbType.Int).Value = add.ExcerciseSets4;
                cmd.Parameters.Add("@Excercise5", SqlDbType.VarChar).Value = add.Excercise5;
                cmd.Parameters.Add("@ExcerciseReps5", SqlDbType.Int).Value = add.ExcerciseReps5;
                cmd.Parameters.Add("@ExcerciseSets5", SqlDbType.Int).Value = add.ExcerciseSets5;
                cmd.Parameters.Add("@WorkoutName", SqlDbType.VarChar).Value = add.WorkoutName;
                return cmd.ExecuteNonQuery();
            }
        }

        //Delete using "DELETE" Sql Query by the WorkoutID
        //Very similar to the EditWorkout and AddWorkout methods using SqlCommand
        public int DeleteWorkout(int id)
        {
            string sqlQuery = "DELETE from Workouts Where WorkoutID=@ID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
