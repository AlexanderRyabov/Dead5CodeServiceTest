using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadCode
{
	
    class DeadMethod<T>
    {
		private List<OrderItem> orderItems = new List<OrderItem>();
		private class OrderItem
	    {
		}
		private readonly char[] COMMA_SEPARATOR = new char[] { ',' };
		private Dictionary<string, Waveform> _waveforms = new Dictionary<string, Waveform>();
		private string _filename;
		
		private int NotifyPropertyChanged(string propName)
    {
        int a = 2;
		return a;
   }

    }
}
