using Autofac;
using Flexi.Application.Core.Interfaces;
using Flexi.Application.Core.Services;

namespace Flexi.Application.Core;

/// <summary>
/// An Autofac module that is responsible for wiring up services defined in the Core project.
/// </summary>
public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<DeleteContributorService>()
        .As<IDeleteContributorService>().InstancePerLifetimeScope();
    builder.RegisterType<StudentService>()
        .As<IStudentService>().InstancePerLifetimeScope();
  }
}
