using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Web.Mvc;   // DefaultControllerFactory
using Ninject;          // IKernel
using System.Web.Routing;   //RequestContext
using scLInq.Repository.Abstract.FAQ;
using scLInq.Repository.Concrete.FAQ;
using scLInq.Repository.Abstract.ManageLInq;
using scLInq.Repository.Concrete.ManageLInq;

namespace scLInq.WebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            ninjectKernel.Bind<IFAQRepository>().To<FAQRepository>();
            ninjectKernel.Bind<IFaqDocumentRepository>().To<FaqDocumentRepository>();

            ninjectKernel.Bind<ILocationRepository>().To<LocationRepository>();
            ninjectKernel.Bind<IDepartmentRepository>().To<DepartmentRepository>();
            ninjectKernel.Bind<IJobFunctionRepository>().To<JobFunctionRepository>();
        }

    }
}


