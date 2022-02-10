using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Wars
{
    /// <summary>
    /// For every good kata idea there seem to be quite a few bad ones! In this kata you need to check the provided array (x) for good ideas 'good' and bad ideas 'bad'. 
    /// If there are one or two good ideas, return 'Publish!', if there are more than 2 return 'I smell a series!'. If there are no good ideas, as is often the case, return 'Fail!'.
    /// https://www.codewars.com/kata/57f222ce69e09c3630000212/train/csharp
    /// </summary>
    public class WellOfIdeasEasyVersion
    {
        public string Well(string[] srtArr)
        {
            srtArr.Where(m => m.Contains("good")).ToString().Count();
            return "";
        }
    }
}
