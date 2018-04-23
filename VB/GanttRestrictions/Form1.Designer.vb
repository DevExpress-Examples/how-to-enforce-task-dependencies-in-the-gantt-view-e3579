﻿Imports Microsoft.VisualBasic
Imports System
Namespace GanttRestrictions
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.resourcesTree1 = New DevExpress.XtraScheduler.UI.ResourcesTree()
            Me.colIdSort = New DevExpress.XtraScheduler.Native.ResourceTreeColumn()
            Me.colId = New DevExpress.XtraScheduler.Native.ResourceTreeColumn()
            Me.colDescription = New DevExpress.XtraScheduler.Native.ResourceTreeColumn()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.GantTest01DataSet1 = New GantTest01DataSet()
            Me.AppointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.AppointmentsTableAdapter1 = New GantTest01DataSetTableAdapters.AppointmentsTableAdapter()
            Me.ResourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ResourcesTableAdapter1 = New GantTest01DataSetTableAdapters.ResourcesTableAdapter()
            Me.TaskDependenciesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.TaskDependenciesTableAdapter1 = New GantTest01DataSetTableAdapters.TaskDependenciesTableAdapter()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.resourcesTree1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GantTest01DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ResourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TaskDependenciesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'splitContainerControl1
            '
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.resourcesTree1)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.schedulerControl1)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(784, 562)
            Me.splitContainerControl1.SplitterPosition = 186
            Me.splitContainerControl1.TabIndex = 0
            Me.splitContainerControl1.Text = "splitContainerControl1"
            '
            'resourcesTree1
            '
            Me.resourcesTree1.ColumnPanelRowHeight = 55
            Me.resourcesTree1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colIdSort, Me.colId, Me.colDescription})
            Me.resourcesTree1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.resourcesTree1.Location = New System.Drawing.Point(0, 0)
            Me.resourcesTree1.Name = "resourcesTree1"
            Me.resourcesTree1.SchedulerControl = Me.schedulerControl1
            Me.resourcesTree1.Size = New System.Drawing.Size(186, 562)
            Me.resourcesTree1.TabIndex = 0
            '
            'colIdSort
            '
            Me.colIdSort.FieldName = "IdSort"
            Me.colIdSort.Name = "colIdSort"
            Me.colIdSort.SortOrder = System.Windows.Forms.SortOrder.Ascending
            '
            'colId
            '
            Me.colId.FieldName = "Id"
            Me.colId.Name = "colId"
            '
            'colDescription
            '
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 0
            '
            'schedulerControl1
            '
            Me.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Gantt
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(593, 562)
            Me.schedulerControl1.Start = New Date(2011, 11, 1, 0, 0, 0, 0)
            Me.schedulerControl1.Storage = Me.schedulerStorage1
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            '
            'schedulerStorage1
            '
            Me.schedulerStorage1.AppointmentDependencies.DataSource = Me.TaskDependenciesBindingSource
            Me.schedulerStorage1.AppointmentDependencies.Mappings.DependentId = "DependentId"
            Me.schedulerStorage1.AppointmentDependencies.Mappings.ParentId = "ParentId"
            Me.schedulerStorage1.AppointmentDependencies.Mappings.Type = "Type"
            Me.schedulerStorage1.Appointments.DataSource = Me.AppointmentsBindingSource
            Me.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
            Me.schedulerStorage1.Appointments.Mappings.AppointmentId = "UniqueId"
            Me.schedulerStorage1.Appointments.Mappings.Description = "Description"
            Me.schedulerStorage1.Appointments.Mappings.End = "EndDate"
            Me.schedulerStorage1.Appointments.Mappings.Label = "Label"
            Me.schedulerStorage1.Appointments.Mappings.Location = "Location"
            Me.schedulerStorage1.Appointments.Mappings.PercentComplete = "PercentComplete"
            Me.schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
            Me.schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
            Me.schedulerStorage1.Appointments.Mappings.ResourceId = "ResourceId"
            Me.schedulerStorage1.Appointments.Mappings.Start = "StartDate"
            Me.schedulerStorage1.Appointments.Mappings.Status = "Status"
            Me.schedulerStorage1.Appointments.Mappings.Subject = "Subject"
            Me.schedulerStorage1.Appointments.Mappings.Type = "Type"
            Me.schedulerStorage1.Resources.CustomFieldMappings.Add(New DevExpress.XtraScheduler.ResourceCustomFieldMapping("IdSort", "IdSort"))
            Me.schedulerStorage1.Resources.DataSource = Me.ResourcesBindingSource
            Me.schedulerStorage1.Resources.Mappings.Caption = "Description"
            Me.schedulerStorage1.Resources.Mappings.Color = "Color"
            Me.schedulerStorage1.Resources.Mappings.Id = "Id"
            Me.schedulerStorage1.Resources.Mappings.Image = "Image"
            Me.schedulerStorage1.Resources.Mappings.ParentId = "ParentId"
            '
            'GantTest01DataSet1
            '
            Me.GantTest01DataSet1.DataSetName = "GantTest01DataSet"
            Me.GantTest01DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'AppointmentsBindingSource
            '
            Me.AppointmentsBindingSource.DataMember = "Appointments"
            Me.AppointmentsBindingSource.DataSource = Me.GantTest01DataSet1
            '
            'AppointmentsTableAdapter1
            '
            Me.AppointmentsTableAdapter1.ClearBeforeFill = True
            '
            'ResourcesBindingSource
            '
            Me.ResourcesBindingSource.DataMember = "Resources"
            Me.ResourcesBindingSource.DataSource = Me.GantTest01DataSet1
            '
            'ResourcesTableAdapter1
            '
            Me.ResourcesTableAdapter1.ClearBeforeFill = True
            '
            'TaskDependenciesBindingSource
            '
            Me.TaskDependenciesBindingSource.DataMember = "TaskDependencies"
            Me.TaskDependenciesBindingSource.DataSource = Me.GantTest01DataSet1
            '
            'TaskDependenciesTableAdapter1
            '
            Me.TaskDependenciesTableAdapter1.ClearBeforeFill = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 562)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.resourcesTree1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GantTest01DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ResourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TaskDependenciesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
		Private WithEvents schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
		Private resourcesTree1 As DevExpress.XtraScheduler.UI.ResourcesTree
		Private gantTest01DataSet As GantTest01DataSet
        Private appointmentsTableAdapter As GantTest01DataSetTableAdapters.AppointmentsTableAdapter
        Private resourcesTableAdapter As GantTest01DataSetTableAdapters.ResourcesTableAdapter
        Private taskDependenciesTableAdapter As GantTest01DataSetTableAdapters.TaskDependenciesTableAdapter
		Private colIdSort As DevExpress.XtraScheduler.Native.ResourceTreeColumn
		Private colId As DevExpress.XtraScheduler.Native.ResourceTreeColumn
        Private colDescription As DevExpress.XtraScheduler.Native.ResourceTreeColumn
        Friend WithEvents GantTest01DataSet1 As GantTest01DataSet
        Friend WithEvents AppointmentsBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents AppointmentsTableAdapter1 As GantTest01DataSetTableAdapters.AppointmentsTableAdapter
        Friend WithEvents ResourcesBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents ResourcesTableAdapter1 As GantTest01DataSetTableAdapters.ResourcesTableAdapter
        Friend WithEvents TaskDependenciesBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents TaskDependenciesTableAdapter1 As GantTest01DataSetTableAdapters.TaskDependenciesTableAdapter
    End Class
End Namespace

