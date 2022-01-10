using System;

namespace HybridInheritanceExample
{
	//base 
	class GradFater {
	
		public void land() {
			Console.WriteLine("GradFater's land");
		}
	
	}
	
	class Father : GradFater {
	
		public void home() {
			Console.WriteLine("Father's home");
		}
	
		public void Car() {
			Console.WriteLine("Father's Car");
		}
	}
	
	// Inherit /derived / extends
	class Son : Father {
	
		// son constructor
		public Son() {
			Console.WriteLine("Son...");
		}
	
		public void mobile() {
			Console.WriteLine("Son's mobile");
		}
	}
	
	class Daughter : Father {
	
		// Daughter constructor
		public Daughter() {
			Console.WriteLine("Daughter...");
		}
	
		public void purse() {
			Console.WriteLine("Daughter's purse");
		}
	}
	
	public class HybridInheritance 
	{
	
		public static void Main(String[] args) {
	
			// Son object
			Son objSon = new Son();
			objSon.land();// Grand father method
			objSon.Car(); // Father method
			objSon.home();// Father method
			objSon.mobile();// son method
	
			Console.WriteLine();
			// Daughter object
			Daughter objDaughter = new Daughter();
			objDaughter.land();// Grand father method
			objDaughter.Car(); // Father method
			objDaughter.home();// Father method
			objDaughter.purse();// son method
	
		}
	}
}


/*
Output:
Son...
GradFater's land
Father's Car
Father's home
Son's mobile

Daughter...
GradFater's land
Father's Car
Father's home
Daughter's purse
*/