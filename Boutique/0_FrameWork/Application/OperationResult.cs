using System;
using System.Collections.Generic;
using System.Text;

namespace _0_FrameWork.Application
{
    public class OperationResult
    {
        public bool IsSuccedded { get; set; }

        public string Message { get; set; }

        public OperationResult()
        {
            IsSuccedded = false;
        }


        public OperationResult Succedde(string message="عملیات با موفقیت انجام شد")
        {
            IsSuccedded = true;
            Message = message;
            return this;
        }

        public OperationResult Failed(string message )
        {
            IsSuccedded = false;
            Message = message;
            return this;
        }
    }
}
