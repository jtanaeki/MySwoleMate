<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MySwoleMate.Master" AutoEventWireup="true" CodeBehind="EditWorkout.aspx.cs" Inherits="MySwoleMate.EditWorkout" %>
<%--Add Workout Form--%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="first">
        <div class="container">
            <div class="row">
                <div class="col-xs-12 text-center">
                    <h1>Edit Workout</h1>
                </div>
            </div>
            <div class="form-horizontal">
				<div class="form-group">
					<asp:Label ID="WorkoutNameLabel" runat="server" Text="Workout Name"
						AssociatedControlID="WorkoutName" CssClass="col-xs-4 control-label"></asp:Label>
	                <div class="col-xs-4">
		                <asp:TextBox ID="WorkoutName" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="30"></asp:TextBox>
			            <div class="has-error">
				            <span class="help-block">
					            <asp:RequiredFieldValidator ID="WorkoutNameRequired" runat="server" ErrorMessage="Workout Name is Required"
						            ControlToValidate="WorkoutName" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
							</span>
						</div>
					</div>
				</div>
                <div class="form-group">
                    <asp:Label ID="Excercise1Label" runat="server" Text="1st Excercise"
                        AssociatedControlID="Excercise1" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Excercise1" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="30"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="Excercise1Required" runat="server" ErrorMessage="Excercise is Required"
                                    ControlToValidate="Excercise1" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="ExcerciseReps1Label" runat="server" Text="# of Reps for 1st Excercise"
                        AssociatedControlID="ExcerciseReps1" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-2">
                        <asp:TextBox ID="ExcerciseReps1" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="ExcerciseReps1Required" runat="server" ErrorMessage="Reps is Required"
                                    ControlToValidate="ExcerciseReps1" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="ExcerciseReps1Validator" runat="server" ControlToValidate="ExcerciseReps1" Display="Dynamic"
                                    ValidationGroup="AllValidators" MinimumValue="1" MaximumValue="1000"
                                    ErrorMessage="Please enter a number representing Reps for 1st Excercise of Workout" Type="Integer"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                    <asp:Label ID="ExcerciseSets1Label" runat="server" Text="# of Sets for 1st Excercise"
                        AssociatedControlID="ExcerciseSets1" CssClass="col-xs-2 control-label"></asp:Label>
                    <div class="col-xs-2">
                        <asp:TextBox ID="ExcerciseSets1" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="ExcerciseSets1Required" runat="server" ErrorMessage="Sets is Required"
                                    ControlToValidate="ExcerciseSets1" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="ExcerciseSets1Validator" runat="server" ControlToValidate="ExcerciseSets1" Display="Dynamic"
                                    ValidationGroup="AllValidators" MinimumValue="1" MaximumValue="100"
                                    ErrorMessage="Please enter a number representing Sets for 1st Excercise of Workout" Type="Integer"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
				</div>
				<div class="form-group">
                    <asp:Label ID="Excercise2Label" runat="server" Text="2nd Excercise"
                        AssociatedControlID="Excercise2" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Excercise2" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="30"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="Excercise2Required" runat="server" ErrorMessage="Excercise is Required"
                                    ControlToValidate="Excercise2" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="ExcerciseReps2Label" runat="server" Text="# of Reps for 2nd Excercise"
                        AssociatedControlID="ExcerciseReps2" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-2">
                        <asp:TextBox ID="ExcerciseReps2" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="ExcerciseReps2Required" runat="server" ErrorMessage="Reps is Required"
                                    ControlToValidate="ExcerciseReps2" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="ExcerciseReps2Validator" runat="server" ControlToValidate="ExcerciseReps2" Display="Dynamic"
                                    ValidationGroup="AllValidators" MinimumValue="1" MaximumValue="1000"
                                    ErrorMessage="Please enter a number representing Reps for 2nd Excercise of Workout" Type="Integer"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                    <asp:Label ID="ExcerciseSets2Label" runat="server" Text="# of Sets for 2nd Excercise"
                        AssociatedControlID="ExcerciseSets2" CssClass="col-xs-2 control-label"></asp:Label>
                    <div class="col-xs-2">
                        <asp:TextBox ID="ExcerciseSets2" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="ExcerciseSets2Required" runat="server" ErrorMessage="Sets is Required"
                                    ControlToValidate="ExcerciseSets2" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="ExcerciseSets2Validator" runat="server" ControlToValidate="ExcerciseSets2" Display="Dynamic"
                                    ValidationGroup="AllValidators" MinimumValue="1" MaximumValue="100"
                                    ErrorMessage="Please enter a number representing Sets for 2nd Excercise of Workout" Type="Integer"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div><div class="form-group">
                    <asp:Label ID="Excercise3Label" runat="server" Text="3rd Excercise"
                        AssociatedControlID="Excercise3" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Excercise3" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="30"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="Excercise3Required" runat="server" ErrorMessage="Excercise is Required"
                                    ControlToValidate="Excercise3" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="ExcerciseReps3Label" runat="server" Text="# of Reps for 3rd Excercise"
                        AssociatedControlID="ExcerciseReps3" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-2">
                        <asp:TextBox ID="ExcerciseReps3" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="ExcerciseReps3Required" runat="server" ErrorMessage="Reps is Required"
                                    ControlToValidate="ExcerciseReps3" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="ExcerciseReps3Validator" runat="server" ControlToValidate="ExcerciseReps3" Display="Dynamic"
                                    ValidationGroup="AllValidators" MinimumValue="1" MaximumValue="1000"
                                    ErrorMessage="Please enter a number representing Reps for 3rd Excercise of Workout" Type="Integer"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                    <asp:Label ID="ExcerciseSets3Label" runat="server" Text="# of Sets for 3rd Excercise"
                        AssociatedControlID="ExcerciseSets3" CssClass="col-xs-2 control-label"></asp:Label>
                    <div class="col-xs-2">
                        <asp:TextBox ID="ExcerciseSets3" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="ExcerciseSets3Required" runat="server" ErrorMessage="Sets is Required"
                                    ControlToValidate="ExcerciseSets3" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="ExcerciseSets3Validator" runat="server" ControlToValidate="ExcerciseSets3" Display="Dynamic"
                                    ValidationGroup="AllValidators" MinimumValue="1" MaximumValue="100"
                                    ErrorMessage="Please enter a number representing Sets for 3rd Excercise of Workout" Type="Integer"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div><div class="form-group">
                    <asp:Label ID="Excercise4Label" runat="server" Text="4th Excercise"
                        AssociatedControlID="Excercise4" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Excercise4" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="30"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="Excercise4Required" runat="server" ErrorMessage="Excercise is Required"
                                    ControlToValidate="Excercise4" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="ExcerciseReps4Label" runat="server" Text="# of Reps for 4th Excercise"
                        AssociatedControlID="ExcerciseReps4" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-2">
                        <asp:TextBox ID="ExcerciseReps4" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="ExcerciseReps4Required" runat="server" ErrorMessage="Reps is Required"
                                    ControlToValidate="ExcerciseReps4" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="ExcerciseReps4Validator" runat="server" ControlToValidate="ExcerciseReps4" Display="Dynamic"
                                    ValidationGroup="AllValidators" MinimumValue="1" MaximumValue="1000"
                                    ErrorMessage="Please enter a number representing Reps for 4th Excercise of Workout" Type="Integer"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                    <asp:Label ID="ExcerciseSets4Label" runat="server" Text="# of Sets for 4th Excercise"
                        AssociatedControlID="ExcerciseSets4" CssClass="col-xs-2 control-label"></asp:Label>
                    <div class="col-xs-2">
                        <asp:TextBox ID="ExcerciseSets4" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="ExcerciseSets4Required" runat="server" ErrorMessage="Sets is Required"
                                    ControlToValidate="ExcerciseSets4" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="ExcerciseSets4Validator" runat="server" ControlToValidate="ExcerciseSets4" Display="Dynamic"
                                    ValidationGroup="AllValidators" MinimumValue="1" MaximumValue="100"
                                    ErrorMessage="Please enter a number representing Sets for 4th Excercise of Workout" Type="Integer"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div><div class="form-group">
                    <asp:Label ID="Excercise5Label" runat="server" Text="5th Excercise"
                        AssociatedControlID="Excercise5" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Excercise5" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="30"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="Excercise5Required" runat="server" ErrorMessage="Excercise is Required"
                                    ControlToValidate="Excercise5" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="ExcerciseReps5Label" runat="server" Text="# of Reps for 5th Excercise"
                        AssociatedControlID="ExcerciseReps5" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-2">
                        <asp:TextBox ID="ExcerciseReps5" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="ExcerciseReps5Required" runat="server" ErrorMessage="Reps is Required"
                                    ControlToValidate="ExcerciseReps5" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="ExcerciseReps5Validator" runat="server" ControlToValidate="ExcerciseReps5" Display="Dynamic"
                                    ValidationGroup="AllValidators" MinimumValue="1" MaximumValue="1000"
                                    ErrorMessage="Please enter a number representing Reps for 5th Excercise of Workout" Type="Integer"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                    <asp:Label ID="ExcerciseSets5Label" runat="server" Text="# of Sets for 5th Excercise"
                        AssociatedControlID="ExcerciseSets5" CssClass="col-xs-2 control-label"></asp:Label>
                    <div class="col-xs-2">
                        <asp:TextBox ID="ExcerciseSets5" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="ExcerciseSets5Required" runat="server" ErrorMessage="Sets is Required"
                                    ControlToValidate="ExcerciseSets5" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="ExcerciseSets5Validator" runat="server" ControlToValidate="ExcerciseSets5" Display="Dynamic"
                                    ValidationGroup="AllValidators" MinimumValue="1" MaximumValue="100"
                                    ErrorMessage="Please enter a number representing Sets for 5th Excercise of Workout" Type="Integer"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-4 col-xs-offset-4">
                        <asp:Button ID="WorkoutEditButton" runat="server" Text="Submit" CssClass="btn btn-success"
                            OnClick="WorkoutEditButton_Click" ValidationGroup="AllValidators" />
                        <asp:HyperLink CssClass="btn btn-default" NavigateUrl="~/Workouts.aspx" runat="server" Text="Back" />
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>