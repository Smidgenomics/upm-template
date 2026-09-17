using System.Runtime.CompilerServices;

#if UNITY_EDITOR
[assembly: InternalsVisibleTo("MyOrganization.MyPlugin.Editor")]
[assembly: InternalsVisibleTo("MyOrganization.MyPlugin.Tests")]
#endif