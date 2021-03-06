﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace winq_linq
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="my_db")]
	public partial class mydbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertcustomer_table(customer_table instance);
    partial void Updatecustomer_table(customer_table instance);
    partial void Deletecustomer_table(customer_table instance);
    #endregion
		
		public mydbDataContext() : 
				base(global::winq_linq.Properties.Settings.Default.my_dbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public mydbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public mydbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public mydbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public mydbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<customer_table> customer_tables
		{
			get
			{
				return this.GetTable<customer_table>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.customer_table")]
	public partial class customer_table : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _customerid;
		
		private string _customername;
		
		private System.Nullable<int> _customerage;
		
		private string _customercity;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncustomeridChanging(int value);
    partial void OncustomeridChanged();
    partial void OncustomernameChanging(string value);
    partial void OncustomernameChanged();
    partial void OncustomerageChanging(System.Nullable<int> value);
    partial void OncustomerageChanged();
    partial void OncustomercityChanging(string value);
    partial void OncustomercityChanged();
    #endregion
		
		public customer_table()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customerid", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int customerid
		{
			get
			{
				return this._customerid;
			}
			set
			{
				if ((this._customerid != value))
				{
					this.OncustomeridChanging(value);
					this.SendPropertyChanging();
					this._customerid = value;
					this.SendPropertyChanged("customerid");
					this.OncustomeridChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customername", DbType="VarChar(50)")]
		public string customername
		{
			get
			{
				return this._customername;
			}
			set
			{
				if ((this._customername != value))
				{
					this.OncustomernameChanging(value);
					this.SendPropertyChanging();
					this._customername = value;
					this.SendPropertyChanged("customername");
					this.OncustomernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customerage", DbType="Int")]
		public System.Nullable<int> customerage
		{
			get
			{
				return this._customerage;
			}
			set
			{
				if ((this._customerage != value))
				{
					this.OncustomerageChanging(value);
					this.SendPropertyChanging();
					this._customerage = value;
					this.SendPropertyChanged("customerage");
					this.OncustomerageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customercity", DbType="VarChar(50)")]
		public string customercity
		{
			get
			{
				return this._customercity;
			}
			set
			{
				if ((this._customercity != value))
				{
					this.OncustomercityChanging(value);
					this.SendPropertyChanging();
					this._customercity = value;
					this.SendPropertyChanged("customercity");
					this.OncustomercityChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
