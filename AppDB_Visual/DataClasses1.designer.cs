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

namespace AppDB_Visual
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Empresa")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDepartamento(Departamento instance);
    partial void UpdateDepartamento(Departamento instance);
    partial void DeleteDepartamento(Departamento instance);
    partial void InsertFuncionario(Funcionario instance);
    partial void UpdateFuncionario(Funcionario instance);
    partial void DeleteFuncionario(Funcionario instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::AppDB_Visual.Properties.Settings.Default.EmpresaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Departamento> Departamentos
		{
			get
			{
				return this.GetTable<Departamento>();
			}
		}
		
		public System.Data.Linq.Table<Funcionario> Funcionarios
		{
			get
			{
				return this.GetTable<Funcionario>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Departamentos")]
	public partial class Departamento : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Sigla;
		
		private string _Departamento1;
		
		private EntitySet<Funcionario> _Funcionarios;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSiglaChanging(string value);
    partial void OnSiglaChanged();
    partial void OnDepartamento1Changing(string value);
    partial void OnDepartamento1Changed();
    #endregion
		
		public Departamento()
		{
			this._Funcionarios = new EntitySet<Funcionario>(new Action<Funcionario>(this.attach_Funcionarios), new Action<Funcionario>(this.detach_Funcionarios));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sigla", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Sigla
		{
			get
			{
				return this._Sigla;
			}
			set
			{
				if ((this._Sigla != value))
				{
					this.OnSiglaChanging(value);
					this.SendPropertyChanging();
					this._Sigla = value;
					this.SendPropertyChanged("Sigla");
					this.OnSiglaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Departamento", Storage="_Departamento1", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Departamento1
		{
			get
			{
				return this._Departamento1;
			}
			set
			{
				if ((this._Departamento1 != value))
				{
					this.OnDepartamento1Changing(value);
					this.SendPropertyChanging();
					this._Departamento1 = value;
					this.SendPropertyChanged("Departamento1");
					this.OnDepartamento1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Departamento_Funcionario", Storage="_Funcionarios", ThisKey="Sigla", OtherKey="Departamento")]
		public EntitySet<Funcionario> Funcionarios
		{
			get
			{
				return this._Funcionarios;
			}
			set
			{
				this._Funcionarios.Assign(value);
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
		
		private void attach_Funcionarios(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.Departamento1 = this;
		}
		
		private void detach_Funcionarios(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.Departamento1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Funcionarios")]
	public partial class Funcionario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Nome;
		
		private string _Departamento;
		
		private EntityRef<Departamento> _Departamento1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    partial void OnDepartamentoChanging(string value);
    partial void OnDepartamentoChanged();
    #endregion
		
		public Funcionario()
		{
			this._Departamento1 = default(EntityRef<Departamento>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Departamento", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Departamento
		{
			get
			{
				return this._Departamento;
			}
			set
			{
				if ((this._Departamento != value))
				{
					if (this._Departamento1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDepartamentoChanging(value);
					this.SendPropertyChanging();
					this._Departamento = value;
					this.SendPropertyChanged("Departamento");
					this.OnDepartamentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Departamento_Funcionario", Storage="_Departamento1", ThisKey="Departamento", OtherKey="Sigla", IsForeignKey=true)]
		public Departamento Departamento1
		{
			get
			{
				return this._Departamento1.Entity;
			}
			set
			{
				Departamento previousValue = this._Departamento1.Entity;
				if (((previousValue != value) 
							|| (this._Departamento1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Departamento1.Entity = null;
						previousValue.Funcionarios.Remove(this);
					}
					this._Departamento1.Entity = value;
					if ((value != null))
					{
						value.Funcionarios.Add(this);
						this._Departamento = value.Sigla;
					}
					else
					{
						this._Departamento = default(string);
					}
					this.SendPropertyChanged("Departamento1");
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