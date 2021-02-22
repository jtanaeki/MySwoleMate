<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MySwoleMate.Master" AutoEventWireup="true" CodeBehind="AssignWorkout.aspx.cs" Inherits="MySwoleMate.AssignWorkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<section class="first">
		<div class="container">
			<div class="row">
                <div class="col-xs-12 text-center">
                    <h1>Assign Workout</h1>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-12 text-center">
                    <h3><asp:Label ID="FirstName" runat="server" /> <asp:Label ID="LastName" runat="server" /></h3>
                </div>
            </div>
            <div class="form-group">
                <div class="col-xs-8 col-xs-offset-2 text-center">
					<asp:DropDownList ID="WorkoutList" CssClass="form-control" runat="server">
					</asp:DropDownList>
                    <div class="has-error">
                        <span class="help-block">
                             <asp:RequiredFieldValidator ID="WorkoutListRequired" runat="server" ErrorMessage="Please Assign a Workout"
                                InitialValue="0" ControlToValidate="WorkoutList" Display="Dynamic" ValidationGroup="AllValidators">
                             </asp:RequiredFieldValidator>
                        </span>
                    </div>
                </div>
            </div>
			<div class="form-group">
                <div class="col-xs-4 col-xs-offset-4 text-center">
                    <asp:Button ID="WorkoutAssignButton" runat="server" Text="Assign" CssClass="btn btn-success"
                        OnClick="WorkoutAssignButton_Click" ValidationGroup="AllValidators" />
                    <asp:HyperLink CssClass="btn btn-default" NavigateUrl="~/Trainees.aspx" runat="server" Text="Back" />
                </div>
            </div>
        </div>
	</section>
</asp:Content>
