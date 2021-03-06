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

namespace HomeWorkDB
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HomeWorkDB")]
	public partial class HomeWorkDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomer(HomeWorkDB.Model.Customer instance);
    partial void UpdateCustomer(HomeWorkDB.Model.Customer instance);
    partial void DeleteCustomer(HomeWorkDB.Model.Customer instance);
    partial void InsertOrder(HomeWorkDB.Model.Order instance);
    partial void UpdateOrder(HomeWorkDB.Model.Order instance);
    partial void DeleteOrder(HomeWorkDB.Model.Order instance);
    partial void InsertProduct(HomeWorkDB.Model.Product instance);
    partial void UpdateProduct(HomeWorkDB.Model.Product instance);
    partial void DeleteProduct(HomeWorkDB.Model.Product instance);
    partial void InsertSupplier(HomeWorkDB.Model.Supplier instance);
    partial void UpdateSupplier(HomeWorkDB.Model.Supplier instance);
    partial void DeleteSupplier(HomeWorkDB.Model.Supplier instance);
    #endregion
		
		public HomeWorkDBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["HomeWorkDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public HomeWorkDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HomeWorkDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HomeWorkDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HomeWorkDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<HomeWorkDB.Model.Customer> Customers
		{
			get
			{
				return this.GetTable<HomeWorkDB.Model.Customer>();
			}
		}
		
		public System.Data.Linq.Table<HomeWorkDB.Model.Order> Orders
		{
			get
			{
				return this.GetTable<HomeWorkDB.Model.Order>();
			}
		}
		
		public System.Data.Linq.Table<HomeWorkDB.Model.Product> Products
		{
			get
			{
				return this.GetTable<HomeWorkDB.Model.Product>();
			}
		}
		
		public System.Data.Linq.Table<HomeWorkDB.Model.Supplier> Suppliers
		{
			get
			{
				return this.GetTable<HomeWorkDB.Model.Supplier>();
			}
		}
	}
}
namespace HomeWorkDB.Model
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customers")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _cid;
		
		private string _cname;
		
		private string _cAddress;
		
		private string _cEmail;
		
		private System.Nullable<long> _cPhone;
		
		private EntitySet<Order> _Orders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncidChanging(int value);
    partial void OncidChanged();
    partial void OncnameChanging(string value);
    partial void OncnameChanged();
    partial void OncAddressChanging(string value);
    partial void OncAddressChanged();
    partial void OncEmailChanging(string value);
    partial void OncEmailChanged();
    partial void OncPhoneChanging(System.Nullable<long> value);
    partial void OncPhoneChanged();
    #endregion
		
		public Customer()
		{
			this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cid", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int cid
		{
			get
			{
				return this._cid;
			}
			set
			{
				if ((this._cid != value))
				{
					this.OncidChanging(value);
					this.SendPropertyChanging();
					this._cid = value;
					this.SendPropertyChanged("cid");
					this.OncidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cname", DbType="NVarChar(50)")]
		public string cname
		{
			get
			{
				return this._cname;
			}
			set
			{
				if ((this._cname != value))
				{
					this.OncnameChanging(value);
					this.SendPropertyChanging();
					this._cname = value;
					this.SendPropertyChanged("cname");
					this.OncnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cAddress", DbType="NVarChar(80)")]
		public string cAddress
		{
			get
			{
				return this._cAddress;
			}
			set
			{
				if ((this._cAddress != value))
				{
					this.OncAddressChanging(value);
					this.SendPropertyChanging();
					this._cAddress = value;
					this.SendPropertyChanged("cAddress");
					this.OncAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cEmail", DbType="NVarChar(80)")]
		public string cEmail
		{
			get
			{
				return this._cEmail;
			}
			set
			{
				if ((this._cEmail != value))
				{
					this.OncEmailChanging(value);
					this.SendPropertyChanging();
					this._cEmail = value;
					this.SendPropertyChanged("cEmail");
					this.OncEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cPhone", DbType="BigInt")]
		public System.Nullable<long> cPhone
		{
			get
			{
				return this._cPhone;
			}
			set
			{
				if ((this._cPhone != value))
				{
					this.OncPhoneChanging(value);
					this.SendPropertyChanging();
					this._cPhone = value;
					this.SendPropertyChanged("cPhone");
					this.OncPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Order", Storage="_Orders", ThisKey="cid", OtherKey="cid")]
		public EntitySet<Order> Orders
		{
			get
			{
				return this._Orders;
			}
			set
			{
				this._Orders.Assign(value);
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
		
		private void attach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Orders")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _oid;
		
		private int _cid;
		
		private int _pid;
		
		private int _oQty;
		
		private decimal _oPrice;
		
		private EntityRef<Customer> _Customer;
		
		private EntityRef<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnoidChanging(int value);
    partial void OnoidChanged();
    partial void OncidChanging(int value);
    partial void OncidChanged();
    partial void OnpidChanging(int value);
    partial void OnpidChanged();
    partial void OnoQtyChanging(int value);
    partial void OnoQtyChanged();
    partial void OnoPriceChanging(decimal value);
    partial void OnoPriceChanged();
    #endregion
		
		public Order()
		{
			this._Customer = default(EntityRef<Customer>);
			this._Product = default(EntityRef<Product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_oid", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int oid
		{
			get
			{
				return this._oid;
			}
			set
			{
				if ((this._oid != value))
				{
					this.OnoidChanging(value);
					this.SendPropertyChanging();
					this._oid = value;
					this.SendPropertyChanged("oid");
					this.OnoidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cid", DbType="Int NOT NULL")]
		public int cid
		{
			get
			{
				return this._cid;
			}
			set
			{
				if ((this._cid != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncidChanging(value);
					this.SendPropertyChanging();
					this._cid = value;
					this.SendPropertyChanged("cid");
					this.OncidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pid", DbType="Int NOT NULL")]
		public int pid
		{
			get
			{
				return this._pid;
			}
			set
			{
				if ((this._pid != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnpidChanging(value);
					this.SendPropertyChanging();
					this._pid = value;
					this.SendPropertyChanged("pid");
					this.OnpidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_oQty", DbType="Int NOT NULL")]
		public int oQty
		{
			get
			{
				return this._oQty;
			}
			set
			{
				if ((this._oQty != value))
				{
					this.OnoQtyChanging(value);
					this.SendPropertyChanging();
					this._oQty = value;
					this.SendPropertyChanged("oQty");
					this.OnoQtyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_oPrice", DbType="Decimal(18,0) NOT NULL")]
		public decimal oPrice
		{
			get
			{
				return this._oPrice;
			}
			set
			{
				if ((this._oPrice != value))
				{
					this.OnoPriceChanging(value);
					this.SendPropertyChanging();
					this._oPrice = value;
					this.SendPropertyChanged("oPrice");
					this.OnoPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Order", Storage="_Customer", ThisKey="cid", OtherKey="cid", IsForeignKey=true)]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.Orders.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.Orders.Add(this);
						this._cid = value.cid;
					}
					else
					{
						this._cid = default(int);
					}
					this.SendPropertyChanged("Customer");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Order", Storage="_Product", ThisKey="pid", OtherKey="pid", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Orders.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Orders.Add(this);
						this._pid = value.pid;
					}
					else
					{
						this._pid = default(int);
					}
					this.SendPropertyChanged("Product");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Products")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _pid;
		
		private string _pName;
		
		private System.Nullable<int> _PQty;
		
		private System.Nullable<decimal> _pPrice;
		
		private int _supID;
		
		private EntitySet<Order> _Orders;
		
		private EntityRef<Supplier> _Supplier;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnpidChanging(int value);
    partial void OnpidChanged();
    partial void OnpNameChanging(string value);
    partial void OnpNameChanged();
    partial void OnPQtyChanging(System.Nullable<int> value);
    partial void OnPQtyChanged();
    partial void OnpPriceChanging(System.Nullable<decimal> value);
    partial void OnpPriceChanged();
    partial void OnsupIDChanging(int value);
    partial void OnsupIDChanged();
    #endregion
		
		public Product()
		{
			this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
			this._Supplier = default(EntityRef<Supplier>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pid", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int pid
		{
			get
			{
				return this._pid;
			}
			set
			{
				if ((this._pid != value))
				{
					this.OnpidChanging(value);
					this.SendPropertyChanging();
					this._pid = value;
					this.SendPropertyChanged("pid");
					this.OnpidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pName", DbType="NVarChar(80)")]
		public string pName
		{
			get
			{
				return this._pName;
			}
			set
			{
				if ((this._pName != value))
				{
					this.OnpNameChanging(value);
					this.SendPropertyChanging();
					this._pName = value;
					this.SendPropertyChanged("pName");
					this.OnpNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PQty", DbType="Int")]
		public System.Nullable<int> PQty
		{
			get
			{
				return this._PQty;
			}
			set
			{
				if ((this._PQty != value))
				{
					this.OnPQtyChanging(value);
					this.SendPropertyChanging();
					this._PQty = value;
					this.SendPropertyChanged("PQty");
					this.OnPQtyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pPrice", DbType="Decimal(8,2)")]
		public System.Nullable<decimal> pPrice
		{
			get
			{
				return this._pPrice;
			}
			set
			{
				if ((this._pPrice != value))
				{
					this.OnpPriceChanging(value);
					this.SendPropertyChanging();
					this._pPrice = value;
					this.SendPropertyChanged("pPrice");
					this.OnpPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_supID", DbType="Int NOT NULL")]
		public int supID
		{
			get
			{
				return this._supID;
			}
			set
			{
				if ((this._supID != value))
				{
					if (this._Supplier.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnsupIDChanging(value);
					this.SendPropertyChanging();
					this._supID = value;
					this.SendPropertyChanged("supID");
					this.OnsupIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Order", Storage="_Orders", ThisKey="pid", OtherKey="pid")]
		public EntitySet<Order> Orders
		{
			get
			{
				return this._Orders;
			}
			set
			{
				this._Orders.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Supplier_Product", Storage="_Supplier", ThisKey="supID", OtherKey="supID", IsForeignKey=true)]
		public Supplier Supplier
		{
			get
			{
				return this._Supplier.Entity;
			}
			set
			{
				Supplier previousValue = this._Supplier.Entity;
				if (((previousValue != value) 
							|| (this._Supplier.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Supplier.Entity = null;
						previousValue.Products.Remove(this);
					}
					this._Supplier.Entity = value;
					if ((value != null))
					{
						value.Products.Add(this);
						this._supID = value.supID;
					}
					else
					{
						this._supID = default(int);
					}
					this.SendPropertyChanged("Supplier");
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
		
		private void attach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Suppliers")]
	public partial class Supplier : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _supID;
		
		private string _supName;
		
		private string _supAddress;
		
		private EntitySet<Product> _Products;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnsupIDChanging(int value);
    partial void OnsupIDChanged();
    partial void OnsupNameChanging(string value);
    partial void OnsupNameChanged();
    partial void OnsupAddressChanging(string value);
    partial void OnsupAddressChanged();
    #endregion
		
		public Supplier()
		{
			this._Products = new EntitySet<Product>(new Action<Product>(this.attach_Products), new Action<Product>(this.detach_Products));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_supID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int supID
		{
			get
			{
				return this._supID;
			}
			set
			{
				if ((this._supID != value))
				{
					this.OnsupIDChanging(value);
					this.SendPropertyChanging();
					this._supID = value;
					this.SendPropertyChanged("supID");
					this.OnsupIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_supName", DbType="NVarChar(50)")]
		public string supName
		{
			get
			{
				return this._supName;
			}
			set
			{
				if ((this._supName != value))
				{
					this.OnsupNameChanging(value);
					this.SendPropertyChanging();
					this._supName = value;
					this.SendPropertyChanged("supName");
					this.OnsupNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_supAddress", DbType="NVarChar(50)")]
		public string supAddress
		{
			get
			{
				return this._supAddress;
			}
			set
			{
				if ((this._supAddress != value))
				{
					this.OnsupAddressChanging(value);
					this.SendPropertyChanging();
					this._supAddress = value;
					this.SendPropertyChanged("supAddress");
					this.OnsupAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Supplier_Product", Storage="_Products", ThisKey="supID", OtherKey="supID")]
		public EntitySet<Product> Products
		{
			get
			{
				return this._Products;
			}
			set
			{
				this._Products.Assign(value);
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
		
		private void attach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Supplier = this;
		}
		
		private void detach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Supplier = null;
		}
	}
}
#pragma warning restore 1591
