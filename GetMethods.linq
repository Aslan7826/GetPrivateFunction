<Query Kind="Program">
  <Connection>
    <ID>c7d73a3f-a613-4cc4-a90e-641821911015</ID>
    <Persist>true</Persist>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>D:\02工作程式碼\Project-company\NewNetPro\MaxPower.NetPro.Web\bin\MaxPower.NetPro.Data.dll</CustomAssemblyPath>
    <CustomTypeName>MaxPower.NetPro.Data.NetProEntityModel</CustomTypeName>
    <AppConfigPath>D:\02工作程式碼\Project-company\NewNetPro\MaxPower.NetPro.Web\bin\MaxPower.NetPro.Data.dll.config</AppConfigPath>
  </Connection>
  <Namespace>System.Reflection</Namespace>
</Query>

void Main()
{
 	new MyClass().insert();;
}

// Define other methods and classes here
public class MyClass
{
	public void insert()
	{
		var methods =  this.GetType()
					   .GetMethods(  BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly)
					   .Where(c=>c.IsPrivate);
		foreach(var m in methods)
		{
  	  		  m.Invoke(this,new object[]{"123"}) ;
		}
	}
	protected  string aaa(string xxx)
	{
		return "error";
	}
	
	private string Foo(string value)
	{
		$"foo{value}".Dump();
		return $"foo{value}";
	}
	private string Bar(string value)
	{
		$"bar{value}".Dump();
		return $"bar{value}";
	}
}