<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MySwoleMate.Master" AutoEventWireup="true" CodeBehind="ViewWorkout.aspx.cs" Inherits="MySwoleMate.ViewWorkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<section class="first">
		<div class="container">
			<div class="row">
                <div class="col-xs-12 text-center">
                    <h1><asp:Label ID="FirstName" runat="server" /> <asp:Label ID="LastName" runat="server" />'s Workout</h1>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-12 text-center">
                    <h3><asp:Label ID="WorkoutName" runat="server" /></h3>
                </div>
            </div>
            <div class="form-group">
                <div class="col-xs-8 col-xs-offset-2 text-center">
					<h5><asp:Label ID="DisplayExcercise1" runat="server" /></h5>
                </div>
                <div class="col-xs-8 col-xs-offset-2 text-center">
					<h5><asp:Label ID="DisplayExcercise2" runat="server" /></h5>
                </div>
                <div class="col-xs-8 col-xs-offset-2 text-center">
					<h5><asp:Label ID="DisplayExcercise3" runat="server" /></h5>
                </div>
                <div class="col-xs-8 col-xs-offset-2 text-center">
					<h5><asp:Label ID="DisplayExcercise4" runat="server" /></h5>
                </div>
                <div class="col-xs-8 col-xs-offset-2 text-center">
					<h5><asp:Label ID="DisplayExcercise5" runat="server" /></h5>
                    <br />
                </div>
            </div>
			<div class="form-group">
                <div class="col-xs-4 col-xs-offset-4 text-center">
                    <asp:Button ID="AssignWorkoutButton" runat="server" Text="Re-Assign Workout" CssClass="btn btn-success"
                        OnClick="AssignWorkoutButton_Click" ValidationGroup="AllValidators" />
                    <asp:HyperLink CssClass="btn btn-default" NavigateUrl="~/Trainees.aspx" runat="server" Text="Back" />
                </div>
            </div>
        </div>
	</section>
</asp:Content>
