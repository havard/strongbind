namespace OX.Strongbind.Tests
{
	using System.Windows.Forms;
	using NUnit.Framework;

    [TestFixture]
	public class GeneratedBindingTests
	{
		
		[Test]
		public void TestBindingToControl()
		{
			Control control = new Control();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				Control bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToScrollableControl()
		{
			ScrollableControl control = new ScrollableControl();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				ScrollableControl bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToContainerControl()
		{
			ContainerControl control = new ContainerControl();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				ContainerControl bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToToolStrip()
		{
			ToolStrip control = new ToolStrip();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				ToolStrip bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToBindingNavigator()
		{
			BindingNavigator control = new BindingNavigator();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				BindingNavigator bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeCountItemFormat = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.CountItemFormat);

				Assert.AreEqual(dataBindingsBeforeCountItemFormat + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.CountItemFormat, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.CountItemFormat, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToButton()
		{
			Button control = new Button();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				Button bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeImageIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.ImageIndex);

				Assert.AreEqual(dataBindingsBeforeImageIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ImageIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.ImageIndex, obj.IntValue);

				int dataBindingsBeforeImageKey = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.ImageKey);

				Assert.AreEqual(dataBindingsBeforeImageKey + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ImageKey, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.ImageKey, obj.Name);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToCheckBox()
		{
			CheckBox control = new CheckBox();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				CheckBox bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeImageIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.ImageIndex);

				Assert.AreEqual(dataBindingsBeforeImageIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ImageIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.ImageIndex, obj.IntValue);

				int dataBindingsBeforeImageKey = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.ImageKey);

				Assert.AreEqual(dataBindingsBeforeImageKey + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ImageKey, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.ImageKey, obj.Name);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToListBox()
		{
			ListBox control = new ListBox();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				ListBox bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeColumnWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.ColumnWidth);

				Assert.AreEqual(dataBindingsBeforeColumnWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ColumnWidth, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.ColumnWidth, obj.IntValue);

				int dataBindingsBeforeHorizontalExtent = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.HorizontalExtent);

				Assert.AreEqual(dataBindingsBeforeHorizontalExtent + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.HorizontalExtent, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.HorizontalExtent, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeDisplayMember = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.DisplayMember);

				Assert.AreEqual(dataBindingsBeforeDisplayMember + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.DisplayMember, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.DisplayMember, obj.Name);

				int dataBindingsBeforeFormatString = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.FormatString);

				Assert.AreEqual(dataBindingsBeforeFormatString + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.FormatString, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.FormatString, obj.Name);

				int dataBindingsBeforeValueMember = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.ValueMember);

				Assert.AreEqual(dataBindingsBeforeValueMember + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ValueMember, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.ValueMember, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToCheckedListBox()
		{
			CheckedListBox control = new CheckedListBox();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				CheckedListBox bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeDisplayMember = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.DisplayMember);

				Assert.AreEqual(dataBindingsBeforeDisplayMember + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.DisplayMember, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.DisplayMember, obj.Name);

				int dataBindingsBeforeValueMember = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.ValueMember);

				Assert.AreEqual(dataBindingsBeforeValueMember + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ValueMember, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.ValueMember, obj.Name);

				int dataBindingsBeforeColumnWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.ColumnWidth);

				Assert.AreEqual(dataBindingsBeforeColumnWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ColumnWidth, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.ColumnWidth, obj.IntValue);

				int dataBindingsBeforeHorizontalExtent = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.HorizontalExtent);

				Assert.AreEqual(dataBindingsBeforeHorizontalExtent + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.HorizontalExtent, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.HorizontalExtent, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeFormatString = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.FormatString);

				Assert.AreEqual(dataBindingsBeforeFormatString + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.FormatString, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.FormatString, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToComboBox()
		{
			ComboBox control = new ComboBox();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				ComboBox bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeDropDownWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.DropDownWidth);

				Assert.AreEqual(dataBindingsBeforeDropDownWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.DropDownWidth, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.DropDownWidth, obj.IntValue);

				int dataBindingsBeforeDropDownHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.DropDownHeight);

				Assert.AreEqual(dataBindingsBeforeDropDownHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.DropDownHeight, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.DropDownHeight, obj.IntValue);

				int dataBindingsBeforeMaxDropDownItems = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.MaxDropDownItems);

				Assert.AreEqual(dataBindingsBeforeMaxDropDownItems + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.MaxDropDownItems, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.MaxDropDownItems, obj.IntValue);

				int dataBindingsBeforeMaxLength = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.MaxLength);

				Assert.AreEqual(dataBindingsBeforeMaxLength + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.MaxLength, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.MaxLength, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeDisplayMember = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.DisplayMember);

				Assert.AreEqual(dataBindingsBeforeDisplayMember + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.DisplayMember, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.DisplayMember, obj.Name);

				int dataBindingsBeforeFormatString = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.FormatString);

				Assert.AreEqual(dataBindingsBeforeFormatString + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.FormatString, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.FormatString, obj.Name);

				int dataBindingsBeforeValueMember = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.ValueMember);

				Assert.AreEqual(dataBindingsBeforeValueMember + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ValueMember, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.ValueMember, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToToolStripDropDown()
		{
			ToolStripDropDown control = new ToolStripDropDown();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				ToolStripDropDown bindableTarget = scope.CreateTarget(control);

			}
		}
		

		[Test]
		public void TestBindingToToolStripDropDownMenu()
		{
			ToolStripDropDownMenu control = new ToolStripDropDownMenu();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				ToolStripDropDownMenu bindableTarget = scope.CreateTarget(control);

			}
		}
		

		[Test]
		public void TestBindingToContextMenuStrip()
		{
			ContextMenuStrip control = new ContextMenuStrip();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				ContextMenuStrip bindableTarget = scope.CreateTarget(control);

			}
		}
		

		[Test]
		public void TestBindingToDataGrid()
		{
			DataGrid control = new DataGrid();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				DataGrid bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeCaptionText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.CaptionText);

				Assert.AreEqual(dataBindingsBeforeCaptionText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.CaptionText, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.CaptionText, obj.Name);

				int dataBindingsBeforeDataMember = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.DataMember);

				Assert.AreEqual(dataBindingsBeforeDataMember + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.DataMember, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.DataMember, obj.Name);

				int dataBindingsBeforePreferredColumnWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.PreferredColumnWidth);

				Assert.AreEqual(dataBindingsBeforePreferredColumnWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.PreferredColumnWidth, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.PreferredColumnWidth, obj.IntValue);

				int dataBindingsBeforePreferredRowHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.PreferredRowHeight);

				Assert.AreEqual(dataBindingsBeforePreferredRowHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.PreferredRowHeight, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.PreferredRowHeight, obj.IntValue);

				int dataBindingsBeforeRowHeaderWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.RowHeaderWidth);

				Assert.AreEqual(dataBindingsBeforeRowHeaderWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.RowHeaderWidth, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.RowHeaderWidth, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToTextBox()
		{
			TextBox control = new TextBox();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				TextBox bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeMaxLength = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.MaxLength);

				Assert.AreEqual(dataBindingsBeforeMaxLength + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.MaxLength, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.MaxLength, obj.IntValue);

				int dataBindingsBeforeSelectionLength = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.SelectionLength);

				Assert.AreEqual(dataBindingsBeforeSelectionLength + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.SelectionLength, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.SelectionLength, obj.IntValue);

				int dataBindingsBeforeSelectionStart = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.SelectionStart);

				Assert.AreEqual(dataBindingsBeforeSelectionStart + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.SelectionStart, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.SelectionStart, obj.IntValue);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToDataGridTextBox()
		{
			DataGridTextBox control = new DataGridTextBox();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				DataGridTextBox bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeMaxLength = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.MaxLength);

				Assert.AreEqual(dataBindingsBeforeMaxLength + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.MaxLength, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.MaxLength, obj.IntValue);

				int dataBindingsBeforeSelectionLength = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.SelectionLength);

				Assert.AreEqual(dataBindingsBeforeSelectionLength + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.SelectionLength, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.SelectionLength, obj.IntValue);

				int dataBindingsBeforeSelectionStart = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.SelectionStart);

				Assert.AreEqual(dataBindingsBeforeSelectionStart + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.SelectionStart, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.SelectionStart, obj.IntValue);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToDataGridView()
		{
			DataGridView control = new DataGridView();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				DataGridView bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeColumnCount = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.ColumnCount);

				Assert.AreEqual(dataBindingsBeforeColumnCount + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ColumnCount, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.ColumnCount, obj.IntValue);

				int dataBindingsBeforeColumnHeadersHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.ColumnHeadersHeight);

				Assert.AreEqual(dataBindingsBeforeColumnHeadersHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ColumnHeadersHeight, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.ColumnHeadersHeight, obj.IntValue);

				int dataBindingsBeforeDataMember = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.DataMember);

				Assert.AreEqual(dataBindingsBeforeDataMember + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.DataMember, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.DataMember, obj.Name);

				int dataBindingsBeforeHorizontalScrollingOffset = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.HorizontalScrollingOffset);

				Assert.AreEqual(dataBindingsBeforeHorizontalScrollingOffset + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.HorizontalScrollingOffset, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.HorizontalScrollingOffset, obj.IntValue);

				int dataBindingsBeforeRowCount = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.RowCount);

				Assert.AreEqual(dataBindingsBeforeRowCount + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.RowCount, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.RowCount, obj.IntValue);

				int dataBindingsBeforeRowHeadersWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.RowHeadersWidth);

				Assert.AreEqual(dataBindingsBeforeRowHeadersWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.RowHeadersWidth, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.RowHeadersWidth, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToDataGridViewComboBoxEditingControl()
		{
			DataGridViewComboBoxEditingControl control = new DataGridViewComboBoxEditingControl();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				DataGridViewComboBoxEditingControl bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeEditingControlRowIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.EditingControlRowIndex);

				Assert.AreEqual(dataBindingsBeforeEditingControlRowIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.EditingControlRowIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.EditingControlRowIndex, obj.IntValue);

				int dataBindingsBeforeDropDownWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.DropDownWidth);

				Assert.AreEqual(dataBindingsBeforeDropDownWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.DropDownWidth, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.DropDownWidth, obj.IntValue);

				int dataBindingsBeforeDropDownHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.DropDownHeight);

				Assert.AreEqual(dataBindingsBeforeDropDownHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.DropDownHeight, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.DropDownHeight, obj.IntValue);

				int dataBindingsBeforeMaxDropDownItems = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.MaxDropDownItems);

				Assert.AreEqual(dataBindingsBeforeMaxDropDownItems + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.MaxDropDownItems, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.MaxDropDownItems, obj.IntValue);

				int dataBindingsBeforeMaxLength = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.MaxLength);

				Assert.AreEqual(dataBindingsBeforeMaxLength + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.MaxLength, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.MaxLength, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeDisplayMember = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.DisplayMember);

				Assert.AreEqual(dataBindingsBeforeDisplayMember + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.DisplayMember, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.DisplayMember, obj.Name);

				int dataBindingsBeforeFormatString = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.FormatString);

				Assert.AreEqual(dataBindingsBeforeFormatString + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.FormatString, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.FormatString, obj.Name);

				int dataBindingsBeforeValueMember = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.ValueMember);

				Assert.AreEqual(dataBindingsBeforeValueMember + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ValueMember, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.ValueMember, obj.Name);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToDataGridViewTextBoxEditingControl()
		{
			DataGridViewTextBoxEditingControl control = new DataGridViewTextBoxEditingControl();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				DataGridViewTextBoxEditingControl bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeEditingControlRowIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.EditingControlRowIndex);

				Assert.AreEqual(dataBindingsBeforeEditingControlRowIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.EditingControlRowIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.EditingControlRowIndex, obj.IntValue);

				int dataBindingsBeforeMaxLength = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.MaxLength);

				Assert.AreEqual(dataBindingsBeforeMaxLength + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.MaxLength, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.MaxLength, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToDateTimePicker()
		{
			DateTimePicker control = new DateTimePicker();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				DateTimePicker bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeCustomFormat = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.CustomFormat);

				Assert.AreEqual(dataBindingsBeforeCustomFormat + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.CustomFormat, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.CustomFormat, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToDomainUpDown()
		{
			DomainUpDown control = new DomainUpDown();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				DomainUpDown bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToPanel()
		{
			Panel control = new Panel();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				Panel bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToFlowLayoutPanel()
		{
			FlowLayoutPanel control = new FlowLayoutPanel();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				FlowLayoutPanel bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToForm()
		{
			Form control = new Form();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				Form bindableTarget = scope.CreateTarget(control);

			}
		}
		

		[Test]
		public void TestBindingToGroupBox()
		{
			GroupBox control = new GroupBox();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				GroupBox bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToHScrollBar()
		{
			HScrollBar control = new HScrollBar();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				HScrollBar bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeLargeChange = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.LargeChange);

				Assert.AreEqual(dataBindingsBeforeLargeChange + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.LargeChange, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.LargeChange, obj.IntValue);

				int dataBindingsBeforeMaximum = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Maximum);

				Assert.AreEqual(dataBindingsBeforeMaximum + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Maximum, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Maximum, obj.IntValue);

				int dataBindingsBeforeMinimum = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Minimum);

				Assert.AreEqual(dataBindingsBeforeMinimum + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Minimum, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Minimum, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeValue = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Value);

				Assert.AreEqual(dataBindingsBeforeValue + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Value, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Value, obj.IntValue);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToLabel()
		{
			Label control = new Label();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				Label bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeImageIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.ImageIndex);

				Assert.AreEqual(dataBindingsBeforeImageIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ImageIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.ImageIndex, obj.IntValue);

				int dataBindingsBeforeImageKey = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.ImageKey);

				Assert.AreEqual(dataBindingsBeforeImageKey + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ImageKey, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.ImageKey, obj.Name);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToLinkLabel()
		{
			LinkLabel control = new LinkLabel();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				LinkLabel bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeImageIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.ImageIndex);

				Assert.AreEqual(dataBindingsBeforeImageIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ImageIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.ImageIndex, obj.IntValue);

				int dataBindingsBeforeImageKey = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.ImageKey);

				Assert.AreEqual(dataBindingsBeforeImageKey + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ImageKey, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.ImageKey, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToListView()
		{
			ListView control = new ListView();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				ListView bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeVirtualListSize = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.VirtualListSize);

				Assert.AreEqual(dataBindingsBeforeVirtualListSize + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.VirtualListSize, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.VirtualListSize, obj.IntValue);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToMaskedTextBox()
		{
			MaskedTextBox control = new MaskedTextBox();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				MaskedTextBox bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeMask = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Mask);

				Assert.AreEqual(dataBindingsBeforeMask + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Mask, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Mask, obj.Name);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToMdiClient()
		{
			MdiClient control = new MdiClient();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				MdiClient bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToMenuStrip()
		{
			MenuStrip control = new MenuStrip();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				MenuStrip bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToMonthCalendar()
		{
			MonthCalendar control = new MonthCalendar();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				MonthCalendar bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeMaxSelectionCount = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.MaxSelectionCount);

				Assert.AreEqual(dataBindingsBeforeMaxSelectionCount + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.MaxSelectionCount, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.MaxSelectionCount, obj.IntValue);

				int dataBindingsBeforeScrollChange = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.ScrollChange);

				Assert.AreEqual(dataBindingsBeforeScrollChange + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ScrollChange, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.ScrollChange, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToNumericUpDown()
		{
			NumericUpDown control = new NumericUpDown();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				NumericUpDown bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeDecimalPlaces = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.DecimalPlaces);

				Assert.AreEqual(dataBindingsBeforeDecimalPlaces + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.DecimalPlaces, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.DecimalPlaces, obj.IntValue);

				int dataBindingsBeforeIncrement = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.DecimalValue).To(bindableTarget.Increment);

				Assert.AreEqual(dataBindingsBeforeIncrement + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Increment, obj.DecimalValue);
				
				obj.ChangeDecimalValue();
				
				Assert.AreEqual(control.Increment, obj.DecimalValue);

				int dataBindingsBeforeMaximum = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.DecimalValue).To(bindableTarget.Maximum);

				Assert.AreEqual(dataBindingsBeforeMaximum + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Maximum, obj.DecimalValue);
				
				obj.ChangeDecimalValue();
				
				Assert.AreEqual(control.Maximum, obj.DecimalValue);

				int dataBindingsBeforeMinimum = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.DecimalValue).To(bindableTarget.Minimum);

				Assert.AreEqual(dataBindingsBeforeMinimum + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Minimum, obj.DecimalValue);
				
				obj.ChangeDecimalValue();
				
				Assert.AreEqual(control.Minimum, obj.DecimalValue);

				int dataBindingsBeforeValue = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.DecimalValue).To(bindableTarget.Value);

				Assert.AreEqual(dataBindingsBeforeValue + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Value, obj.DecimalValue);
				
				obj.ChangeDecimalValue();
				
				Assert.AreEqual(control.Value, obj.DecimalValue);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToPictureBox()
		{
			PictureBox control = new PictureBox();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				PictureBox bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeImageLocation = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.ImageLocation);

				Assert.AreEqual(dataBindingsBeforeImageLocation + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ImageLocation, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.ImageLocation, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToProgressBar()
		{
			ProgressBar control = new ProgressBar();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				ProgressBar bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeMarqueeAnimationSpeed = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.MarqueeAnimationSpeed);

				Assert.AreEqual(dataBindingsBeforeMarqueeAnimationSpeed + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.MarqueeAnimationSpeed, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.MarqueeAnimationSpeed, obj.IntValue);

				int dataBindingsBeforeMaximum = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Maximum);

				Assert.AreEqual(dataBindingsBeforeMaximum + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Maximum, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Maximum, obj.IntValue);

				int dataBindingsBeforeMinimum = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Minimum);

				Assert.AreEqual(dataBindingsBeforeMinimum + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Minimum, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Minimum, obj.IntValue);

				int dataBindingsBeforeStep = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Step);

				Assert.AreEqual(dataBindingsBeforeStep + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Step, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Step, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeValue = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Value);

				Assert.AreEqual(dataBindingsBeforeValue + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Value, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Value, obj.IntValue);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToPropertyGrid()
		{
			PropertyGrid control = new PropertyGrid();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				PropertyGrid bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToRadioButton()
		{
			RadioButton control = new RadioButton();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				RadioButton bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeImageIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.ImageIndex);

				Assert.AreEqual(dataBindingsBeforeImageIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ImageIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.ImageIndex, obj.IntValue);

				int dataBindingsBeforeImageKey = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.ImageKey);

				Assert.AreEqual(dataBindingsBeforeImageKey + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ImageKey, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.ImageKey, obj.Name);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToRichTextBox()
		{
			RichTextBox control = new RichTextBox();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				RichTextBox bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeBulletIndent = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.BulletIndent);

				Assert.AreEqual(dataBindingsBeforeBulletIndent + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.BulletIndent, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.BulletIndent, obj.IntValue);

				int dataBindingsBeforeMaxLength = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.MaxLength);

				Assert.AreEqual(dataBindingsBeforeMaxLength + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.MaxLength, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.MaxLength, obj.IntValue);

				int dataBindingsBeforeRightMargin = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.RightMargin);

				Assert.AreEqual(dataBindingsBeforeRightMargin + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.RightMargin, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.RightMargin, obj.IntValue);

				int dataBindingsBeforeSelectionCharOffset = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.SelectionCharOffset);

				Assert.AreEqual(dataBindingsBeforeSelectionCharOffset + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.SelectionCharOffset, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.SelectionCharOffset, obj.IntValue);

				int dataBindingsBeforeSelectionHangingIndent = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.SelectionHangingIndent);

				Assert.AreEqual(dataBindingsBeforeSelectionHangingIndent + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.SelectionHangingIndent, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.SelectionHangingIndent, obj.IntValue);

				int dataBindingsBeforeSelectionIndent = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.SelectionIndent);

				Assert.AreEqual(dataBindingsBeforeSelectionIndent + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.SelectionIndent, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.SelectionIndent, obj.IntValue);

				int dataBindingsBeforeSelectionRightIndent = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.SelectionRightIndent);

				Assert.AreEqual(dataBindingsBeforeSelectionRightIndent + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.SelectionRightIndent, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.SelectionRightIndent, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeZoomFactor = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.FloatValue).To(bindableTarget.ZoomFactor);

				Assert.AreEqual(dataBindingsBeforeZoomFactor + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ZoomFactor, obj.FloatValue);
				
				obj.ChangeFloatValue();
				
				Assert.AreEqual(control.ZoomFactor, obj.FloatValue);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToSplitContainer()
		{
			SplitContainer control = new SplitContainer();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				SplitContainer bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforePanel1MinSize = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Panel1MinSize);

				Assert.AreEqual(dataBindingsBeforePanel1MinSize + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Panel1MinSize, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Panel1MinSize, obj.IntValue);

				int dataBindingsBeforePanel2MinSize = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Panel2MinSize);

				Assert.AreEqual(dataBindingsBeforePanel2MinSize + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Panel2MinSize, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Panel2MinSize, obj.IntValue);

				int dataBindingsBeforeSplitterDistance = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.SplitterDistance);

				Assert.AreEqual(dataBindingsBeforeSplitterDistance + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.SplitterDistance, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.SplitterDistance, obj.IntValue);

				int dataBindingsBeforeSplitterIncrement = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.SplitterIncrement);

				Assert.AreEqual(dataBindingsBeforeSplitterIncrement + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.SplitterIncrement, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.SplitterIncrement, obj.IntValue);

				int dataBindingsBeforeSplitterWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.SplitterWidth);

				Assert.AreEqual(dataBindingsBeforeSplitterWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.SplitterWidth, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.SplitterWidth, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToSplitter()
		{
			Splitter control = new Splitter();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				Splitter bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeMinExtra = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.MinExtra);

				Assert.AreEqual(dataBindingsBeforeMinExtra + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.MinExtra, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.MinExtra, obj.IntValue);

				int dataBindingsBeforeMinSize = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.MinSize);

				Assert.AreEqual(dataBindingsBeforeMinSize + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.MinSize, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.MinSize, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToStatusBar()
		{
			StatusBar control = new StatusBar();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				StatusBar bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToStatusStrip()
		{
			StatusStrip control = new StatusStrip();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				StatusStrip bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToTabControl()
		{
			TabControl control = new TabControl();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				TabControl bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToTableLayoutPanel()
		{
			TableLayoutPanel control = new TableLayoutPanel();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				TableLayoutPanel bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeColumnCount = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.ColumnCount);

				Assert.AreEqual(dataBindingsBeforeColumnCount + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ColumnCount, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.ColumnCount, obj.IntValue);

				int dataBindingsBeforeRowCount = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.RowCount);

				Assert.AreEqual(dataBindingsBeforeRowCount + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.RowCount, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.RowCount, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToTabPage()
		{
			TabPage control = new TabPage();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				TabPage bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeImageIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.ImageIndex);

				Assert.AreEqual(dataBindingsBeforeImageIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ImageIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.ImageIndex, obj.IntValue);

				int dataBindingsBeforeImageKey = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.ImageKey);

				Assert.AreEqual(dataBindingsBeforeImageKey + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ImageKey, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.ImageKey, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeToolTipText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.ToolTipText);

				Assert.AreEqual(dataBindingsBeforeToolTipText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ToolTipText, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.ToolTipText, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToToolBar()
		{
			ToolBar control = new ToolBar();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				ToolBar bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToToolStripContainer()
		{
			ToolStripContainer control = new ToolStripContainer();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				ToolStripContainer bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToToolStripContentPanel()
		{
			ToolStripContentPanel control = new ToolStripContentPanel();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				ToolStripContentPanel bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToToolStripPanel()
		{
			ToolStripPanel control = new ToolStripPanel();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				ToolStripPanel bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToTrackBar()
		{
			TrackBar control = new TrackBar();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				TrackBar bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeLargeChange = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.LargeChange);

				Assert.AreEqual(dataBindingsBeforeLargeChange + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.LargeChange, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.LargeChange, obj.IntValue);

				int dataBindingsBeforeMaximum = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Maximum);

				Assert.AreEqual(dataBindingsBeforeMaximum + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Maximum, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Maximum, obj.IntValue);

				int dataBindingsBeforeMinimum = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Minimum);

				Assert.AreEqual(dataBindingsBeforeMinimum + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Minimum, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Minimum, obj.IntValue);

				int dataBindingsBeforeSmallChange = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.SmallChange);

				Assert.AreEqual(dataBindingsBeforeSmallChange + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.SmallChange, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.SmallChange, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeTickFrequency = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TickFrequency);

				Assert.AreEqual(dataBindingsBeforeTickFrequency + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TickFrequency, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TickFrequency, obj.IntValue);

				int dataBindingsBeforeValue = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Value);

				Assert.AreEqual(dataBindingsBeforeValue + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Value, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Value, obj.IntValue);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToTreeView()
		{
			TreeView control = new TreeView();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				TreeView bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeImageKey = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.ImageKey);

				Assert.AreEqual(dataBindingsBeforeImageKey + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ImageKey, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.ImageKey, obj.Name);

				int dataBindingsBeforeIndent = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Indent);

				Assert.AreEqual(dataBindingsBeforeIndent + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Indent, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Indent, obj.IntValue);

				int dataBindingsBeforeItemHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.ItemHeight);

				Assert.AreEqual(dataBindingsBeforeItemHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.ItemHeight, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.ItemHeight, obj.IntValue);

				int dataBindingsBeforePathSeparator = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.PathSeparator);

				Assert.AreEqual(dataBindingsBeforePathSeparator + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.PathSeparator, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.PathSeparator, obj.Name);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToUserControl()
		{
			UserControl control = new UserControl();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				UserControl bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToVScrollBar()
		{
			VScrollBar control = new VScrollBar();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				VScrollBar bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeLargeChange = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.LargeChange);

				Assert.AreEqual(dataBindingsBeforeLargeChange + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.LargeChange, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.LargeChange, obj.IntValue);

				int dataBindingsBeforeMaximum = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Maximum);

				Assert.AreEqual(dataBindingsBeforeMaximum + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Maximum, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Maximum, obj.IntValue);

				int dataBindingsBeforeMinimum = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Minimum);

				Assert.AreEqual(dataBindingsBeforeMinimum + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Minimum, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Minimum, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeValue = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Value);

				Assert.AreEqual(dataBindingsBeforeValue + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Value, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Value, obj.IntValue);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToPrintPreviewControl()
		{
			PrintPreviewControl control = new PrintPreviewControl();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				PrintPreviewControl bindableTarget = scope.CreateTarget(control);
				int dataBindingsBeforeColumns = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Columns);

				Assert.AreEqual(dataBindingsBeforeColumns + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Columns, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Columns, obj.IntValue);

				int dataBindingsBeforeRows = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Rows);

				Assert.AreEqual(dataBindingsBeforeRows + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Rows, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Rows, obj.IntValue);

				int dataBindingsBeforeText = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

				Assert.AreEqual(dataBindingsBeforeText + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Text, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Text, obj.Name);

				int dataBindingsBeforeStartPage = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.StartPage);

				Assert.AreEqual(dataBindingsBeforeStartPage + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.StartPage, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.StartPage, obj.IntValue);

				int dataBindingsBeforeZoom = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.DoubleValue).To(bindableTarget.Zoom);

				Assert.AreEqual(dataBindingsBeforeZoom + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Zoom, obj.DoubleValue);
				
				obj.ChangeDoubleValue();
				
				Assert.AreEqual(control.Zoom, obj.DoubleValue);

				int dataBindingsBeforeAccessibleDefaultActionDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDefaultActionDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDefaultActionDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDefaultActionDescription, obj.Name);

				int dataBindingsBeforeAccessibleDescription = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleDescription);

				Assert.AreEqual(dataBindingsBeforeAccessibleDescription + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleDescription, obj.Name);

				int dataBindingsBeforeAccessibleName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.AccessibleName);

				Assert.AreEqual(dataBindingsBeforeAccessibleName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.AccessibleName, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.AccessibleName, obj.Name);

				int dataBindingsBeforeHeight = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Height);

				Assert.AreEqual(dataBindingsBeforeHeight + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Height, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Height, obj.IntValue);

				int dataBindingsBeforeLeft = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Left);

				Assert.AreEqual(dataBindingsBeforeLeft + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Left, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Left, obj.IntValue);

				int dataBindingsBeforeName = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.Name).To(bindableTarget.Name);

				Assert.AreEqual(dataBindingsBeforeName + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Name, obj.Name);
				
				obj.ChangeName();
				
				Assert.AreEqual(control.Name, obj.Name);

				int dataBindingsBeforeTabIndex = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.TabIndex);

				Assert.AreEqual(dataBindingsBeforeTabIndex + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.TabIndex, obj.IntValue);

				int dataBindingsBeforeTop = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Top);

				Assert.AreEqual(dataBindingsBeforeTop + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Top, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Top, obj.IntValue);

				int dataBindingsBeforeWidth = control.DataBindings.Count;
				
				Binder.Bind(bindableSource.IntValue).To(bindableTarget.Width);

				Assert.AreEqual(dataBindingsBeforeWidth + 1, control.DataBindings.Count);
				
				Assert.AreEqual(control.Width, obj.IntValue);
				
				obj.ChangeIntValue();
				
				Assert.AreEqual(control.Width, obj.IntValue);


			}
		}
		

		[Test]
		public void TestBindingToPrintPreviewDialog()
		{
			PrintPreviewDialog control = new PrintPreviewDialog();
			IBusinessObject obj = new BusinessObject();			
			
			using(BindingScope scope = new BindingScope())
			{
				IBusinessObject bindableSource = scope.CreateSource(obj);
				
				if(control is Control)
					((Control)control).CreateControl();
				control.BindingContext = new BindingContext();
			
				PrintPreviewDialog bindableTarget = scope.CreateTarget(control);

			}
		}
		

	}
}