﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryDataLayer
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LibraryDB")]
	public partial class DataLayerClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCatalogItem(CatalogItem instance);
    partial void UpdateCatalogItem(CatalogItem instance);
    partial void DeleteCatalogItem(CatalogItem instance);
    partial void InsertEvent(Event instance);
    partial void UpdateEvent(Event instance);
    partial void DeleteEvent(Event instance);
    partial void InsertState(State instance);
    partial void UpdateState(State instance);
    partial void DeleteState(State instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public DataLayerClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataLayerClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataLayerClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataLayerClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CatalogItem> CatalogItems
		{
			get
			{
				return this.GetTable<CatalogItem>();
			}
		}
		
		public System.Data.Linq.Table<Event> Events
		{
			get
			{
				return this.GetTable<Event>();
			}
		}
		
		public System.Data.Linq.Table<State> States
		{
			get
			{
				return this.GetTable<State>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CatalogItems")]
	public partial class CatalogItem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ItemId;
		
		private string _Name;
		
		private string _Description;
		
		private System.Nullable<decimal> _Price;
		
		private System.Nullable<int> _Quantity;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnItemIdChanging(string value);
    partial void OnItemIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnPriceChanging(System.Nullable<decimal> value);
    partial void OnPriceChanged();
    partial void OnQuantityChanging(System.Nullable<int> value);
    partial void OnQuantityChanged();
    #endregion
		
		public CatalogItem()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemId", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ItemId
		{
			get
			{
				return this._ItemId;
			}
			set
			{
				if ((this._ItemId != value))
				{
					this.OnItemIdChanging(value);
					this.SendPropertyChanging();
					this._ItemId = value;
					this.SendPropertyChanged("ItemId");
					this.OnItemIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100)")]
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
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(255)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int")]
		public System.Nullable<int> Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Events")]
	public partial class Event : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _EventId;
		
		private string _EventName;
		
		private System.Nullable<System.DateTime> _StartTime;
		
		private System.Nullable<System.DateTime> _EndTime;
		
		private string _StateId;
		
		private string _UserId;
		
		private EntityRef<State> _State;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEventIdChanging(string value);
    partial void OnEventIdChanged();
    partial void OnEventNameChanging(string value);
    partial void OnEventNameChanged();
    partial void OnStartTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnStartTimeChanged();
    partial void OnEndTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnEndTimeChanged();
    partial void OnStateIdChanging(string value);
    partial void OnStateIdChanged();
    partial void OnUserIdChanging(string value);
    partial void OnUserIdChanged();
    #endregion
		
		public Event()
		{
			this._State = default(EntityRef<State>);
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventId", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string EventId
		{
			get
			{
				return this._EventId;
			}
			set
			{
				if ((this._EventId != value))
				{
					this.OnEventIdChanging(value);
					this.SendPropertyChanging();
					this._EventId = value;
					this.SendPropertyChanged("EventId");
					this.OnEventIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventName", DbType="NVarChar(100)")]
		public string EventName
		{
			get
			{
				return this._EventName;
			}
			set
			{
				if ((this._EventName != value))
				{
					this.OnEventNameChanging(value);
					this.SendPropertyChanging();
					this._EventName = value;
					this.SendPropertyChanged("EventName");
					this.OnEventNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> StartTime
		{
			get
			{
				return this._StartTime;
			}
			set
			{
				if ((this._StartTime != value))
				{
					this.OnStartTimeChanging(value);
					this.SendPropertyChanging();
					this._StartTime = value;
					this.SendPropertyChanged("StartTime");
					this.OnStartTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> EndTime
		{
			get
			{
				return this._EndTime;
			}
			set
			{
				if ((this._EndTime != value))
				{
					this.OnEndTimeChanging(value);
					this.SendPropertyChanging();
					this._EndTime = value;
					this.SendPropertyChanged("EndTime");
					this.OnEndTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateId", DbType="NVarChar(50)")]
		public string StateId
		{
			get
			{
				return this._StateId;
			}
			set
			{
				if ((this._StateId != value))
				{
					if (this._State.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStateIdChanging(value);
					this.SendPropertyChanging();
					this._StateId = value;
					this.SendPropertyChanged("StateId");
					this.OnStateIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="NVarChar(50)")]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="State_Event", Storage="_State", ThisKey="StateId", OtherKey="StateId", IsForeignKey=true)]
		public State State
		{
			get
			{
				return this._State.Entity;
			}
			set
			{
				State previousValue = this._State.Entity;
				if (((previousValue != value) 
							|| (this._State.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._State.Entity = null;
						previousValue.Events.Remove(this);
					}
					this._State.Entity = value;
					if ((value != null))
					{
						value.Events.Add(this);
						this._StateId = value.StateId;
					}
					else
					{
						this._StateId = default(string);
					}
					this.SendPropertyChanged("State");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Event", Storage="_User", ThisKey="UserId", OtherKey="UserId", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Events.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Events.Add(this);
						this._UserId = value.UserId;
					}
					else
					{
						this._UserId = default(string);
					}
					this.SendPropertyChanged("User");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.States")]
	public partial class State : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _StateId;
		
		private string _StateName;
		
		private string _Description;
		
		private EntitySet<Event> _Events;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStateIdChanging(string value);
    partial void OnStateIdChanged();
    partial void OnStateNameChanging(string value);
    partial void OnStateNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public State()
		{
			this._Events = new EntitySet<Event>(new Action<Event>(this.attach_Events), new Action<Event>(this.detach_Events));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateId", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string StateId
		{
			get
			{
				return this._StateId;
			}
			set
			{
				if ((this._StateId != value))
				{
					this.OnStateIdChanging(value);
					this.SendPropertyChanging();
					this._StateId = value;
					this.SendPropertyChanged("StateId");
					this.OnStateIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateName", DbType="NVarChar(50)")]
		public string StateName
		{
			get
			{
				return this._StateName;
			}
			set
			{
				if ((this._StateName != value))
				{
					this.OnStateNameChanging(value);
					this.SendPropertyChanging();
					this._StateName = value;
					this.SendPropertyChanged("StateName");
					this.OnStateNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(255)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="State_Event", Storage="_Events", ThisKey="StateId", OtherKey="StateId")]
		public EntitySet<Event> Events
		{
			get
			{
				return this._Events;
			}
			set
			{
				this._Events.Assign(value);
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
		
		private void attach_Events(Event entity)
		{
			this.SendPropertyChanging();
			entity.State = this;
		}
		
		private void detach_Events(Event entity)
		{
			this.SendPropertyChanging();
			entity.State = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UserId;
		
		private string _UserName;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _Email;
		
		private EntitySet<Event> _Events;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(string value);
    partial void OnUserIdChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public User()
		{
			this._Events = new EntitySet<Event>(new Action<Event>(this.attach_Events), new Action<Event>(this.detach_Events));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(50)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(100)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Event", Storage="_Events", ThisKey="UserId", OtherKey="UserId")]
		public EntitySet<Event> Events
		{
			get
			{
				return this._Events;
			}
			set
			{
				this._Events.Assign(value);
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
		
		private void attach_Events(Event entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Events(Event entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
}
#pragma warning restore 1591
