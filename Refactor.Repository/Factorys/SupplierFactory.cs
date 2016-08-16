using Lib.Refactor.Enums;
using Refactor.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor.Repository.Factorys
{
    public class SupplierFactory
    {
        public static ISupplierRepository Generate(SupplierEnum supplierType)
        {
            //因為A跟B的SupplierRepository都有實做ISupplierRepository
            //所以這邊可以直接回傳介面，也間接地規範以後新增SupplierRepository都要實作ISupplierRepository介面
            switch (supplierType)
            {
                case SupplierEnum.A:
                    return new ASupplierRepository();
                case SupplierEnum.B:
                    return new BSupplierRepository();
            }

            return null;
        }
    }
}
