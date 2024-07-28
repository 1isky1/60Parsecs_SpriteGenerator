using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_Parsecs_Sprite_Generator
{
	internal class StateKeeper //класс, хранящий последнее состояние rb и cb формы
	{
		private String controlStates; //строка имени персонажа и состояний checked всех rb и cb
		internal StateKeeper() //стандартный
		{
			controlStates = "";
		}
		internal String GetLastStates() //возвращает строку последних состояний checked и выбранного
										//имени персонажа
		{
			return controlStates;
		}

		internal void SaveNewStates(String curr_stats) //сохранить последние изменения статов
		{
			if(curr_stats != controlStates) controlStates = curr_stats;
		}

	}
}
