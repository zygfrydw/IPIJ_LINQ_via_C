﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITSILESIA.IPIJ.IPIJ_SQL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="IPIJ")]
	public partial class DefectModelDataContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DefectModelDataContextDataContext() : 
				base(global::ITSILESIA.IPIJ.IPIJ_SQL.Properties.Settings.Default.SkeetysoftDefectsConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DefectModelDataContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DefectModelDataContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DefectModelDataContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DefectModelDataContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Defect> Defects
		{
			get
			{
				return this.GetTable<Defect>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<NotificationSubscription> NotificationSubscriptions
		{
			get
			{
				return this.GetTable<NotificationSubscription>();
			}
		}
		
		public System.Data.Linq.Table<Project> Projects
		{
			get
			{
				return this.GetTable<Project>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Defect")]
	public partial class Defect
	{
		
		private int _DefectID;
		
		private System.DateTime _Created;
		
		private System.DateTime _LastModified;
		
		private string _Summary;
		
		private byte _Severity;
		
		private byte _Status;
		
		private System.Nullable<int> _AssignedToUserID;
		
		private int _CreatedByUserID;
		
		private int _ProjectID;
		
		public Defect()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DefectID", DbType="Int NOT NULL")]
		public int DefectID
		{
			get
			{
				return this._DefectID;
			}
			set
			{
				if ((this._DefectID != value))
				{
					this._DefectID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Created", DbType="DateTime NOT NULL")]
		public System.DateTime Created
		{
			get
			{
				return this._Created;
			}
			set
			{
				if ((this._Created != value))
				{
					this._Created = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastModified", DbType="DateTime NOT NULL")]
		public System.DateTime LastModified
		{
			get
			{
				return this._LastModified;
			}
			set
			{
				if ((this._LastModified != value))
				{
					this._LastModified = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Summary", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string Summary
		{
			get
			{
				return this._Summary;
			}
			set
			{
				if ((this._Summary != value))
				{
					this._Summary = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Severity", DbType="TinyInt NOT NULL")]
		public byte Severity
		{
			get
			{
				return this._Severity;
			}
			set
			{
				if ((this._Severity != value))
				{
					this._Severity = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="TinyInt NOT NULL")]
		public byte Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this._Status = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AssignedToUserID", DbType="Int")]
		public System.Nullable<int> AssignedToUserID
		{
			get
			{
				return this._AssignedToUserID;
			}
			set
			{
				if ((this._AssignedToUserID != value))
				{
					this._AssignedToUserID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedByUserID", DbType="Int NOT NULL")]
		public int CreatedByUserID
		{
			get
			{
				return this._CreatedByUserID;
			}
			set
			{
				if ((this._CreatedByUserID != value))
				{
					this._CreatedByUserID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectID", DbType="Int NOT NULL")]
		public int ProjectID
		{
			get
			{
				return this._ProjectID;
			}
			set
			{
				if ((this._ProjectID != value))
				{
					this._ProjectID = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DefectUser")]
	public partial class User
	{
		
		private int _UserID;
		
		private string _Name;
		
		private byte _UserType;
		
		public User()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL")]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this._UserID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserType", DbType="TinyInt NOT NULL")]
		public byte UserType
		{
			get
			{
				return this._UserType;
			}
			set
			{
				if ((this._UserType != value))
				{
					this._UserType = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NotificationSubscription")]
	public partial class NotificationSubscription
	{
		
		private int _NotificationSubscriptionID;
		
		private int _ProjectID;
		
		private string _EmailAddress;
		
		public NotificationSubscription()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NotificationSubscriptionID", DbType="Int NOT NULL")]
		public int NotificationSubscriptionID
		{
			get
			{
				return this._NotificationSubscriptionID;
			}
			set
			{
				if ((this._NotificationSubscriptionID != value))
				{
					this._NotificationSubscriptionID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectID", DbType="Int NOT NULL")]
		public int ProjectID
		{
			get
			{
				return this._ProjectID;
			}
			set
			{
				if ((this._ProjectID != value))
				{
					this._ProjectID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailAddress", DbType="NVarChar(80) NOT NULL", CanBeNull=false)]
		public string EmailAddress
		{
			get
			{
				return this._EmailAddress;
			}
			set
			{
				if ((this._EmailAddress != value))
				{
					this._EmailAddress = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Project")]
	public partial class Project
	{
		
		private int _ProjectID;
		
		private string _Name;
		
		public Project()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectID", DbType="Int NOT NULL")]
		public int ProjectID
		{
			get
			{
				return this._ProjectID;
			}
			set
			{
				if ((this._ProjectID != value))
				{
					this._ProjectID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
