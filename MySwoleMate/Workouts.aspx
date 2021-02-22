<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MySwoleMate.Master" AutoEventWireup="true" CodeBehind="Workouts.aspx.cs" Inherits="MySwoleMate.Workouts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="first">
        <div class="container">
            <div class="row">
                <div class="col-xs-10">
                    <h1>Workout List</h1>
                </div>
                <div class="col-xs-2">
                    <a href="~/AddWorkout.aspx" runat="server" class="btn btn-success">Add New Workout</a>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12 text-center">
                    <asp:GridView ID="WorkoutList" runat="server" CssClass="table table-bordered text-left"
                        AutoGenerateColumns="False" OnRowDeleting="WorkoutList_RowDeleting" DataKeyNames="WorkoutID">
                        <Columns>
                            <%--We use HyperLinkField in order to create an Edit button which passes the WorkoutID as a Query String
                                You can see the query string after the "?" in the DataNavigateUrlFormatString property.
                                Anything after the "?" is considered a query string, which you can use to pass information to one
                                page to another. We use the Query String to pass the WorkoutID to the EditWorkout Page.
                                The DataNavigateUrlFormatString replaces the {0} with the DataNavigateUrlFields property, which in 
                                our case is the WorkoutID--%>
                            <asp:HyperLinkField Text="Edit" DataNavigateUrlFields="WorkoutID"
                                DataNavigateUrlFormatString="~/EditWorkout.aspx?WorkoutID={0}" ControlStyle-CssClass="btn btn-success btn-xs"
                                ItemStyle-CssClass="text-center" />
                            <asp:TemplateField ItemStyle-CssClass="text-center">
                                <ItemTemplate>
                                    <%--The Delete functionality is --%>
                                    <asp:Button runat="server" ID="DeleteButton" CommandName="Delete"
                                        CssClass="btn btn-xs btn-default" Text="Delete"
                                        OnClientClick="if(!confirm('Are you sure you wish to delete this workout?')) return false;" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="WorkoutName" HeaderText="Workout Name" />
							<asp:BoundField DataField="DisplayExcercise1" HeaderText="1st Excercise" />
                            <asp:BoundField DataField="DisplayExcercise2" HeaderText="2nd Excercise" />
                            <asp:BoundField DataField="DisplayExcercise3" HeaderText="3rd Excercise" />
                            <asp:BoundField DataField="DisplayExcercise4" HeaderText="4th Excercise" />
                            <asp:BoundField DataField="DisplayExcercise5" HeaderText="5th Excercise" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
