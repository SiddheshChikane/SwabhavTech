using System;
   class ArrayTest
  {
     static void MinArray(int[] arr1){
       int Min=arr1[0];
       for(int i=1;i<arr1.Length;i++){
	    if(arr1[i]<Min){
			Min=arr1[i];
             	}
	}
        Console.WriteLine("Minimum element is:" +Min);
}
     static void Main(string[] args)
    {
	int[] arr1={24,65,34,89,12};
      	  for (int i = 0; i < arr1.Length; i++) 
          {	
            Console.WriteLine(arr1[i]);
      }
	MinArray(arr1);    
    }
  }


    
