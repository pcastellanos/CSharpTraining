using System;
using System.Runtime.CompilerServices;

namespace CSharpTraining
{
    [AttributeUsage(AttributeTargets.All)]
    //own attribute (clase de atributos personalizada)
    public class MemberDescriptionAttribute : Attribute
    {
        public MemberDescriptionAttribute([CallerMemberName] string member = "memberdesc")
        {
            Member = member;
        }

        public string Member { get; set; }
    }

}
