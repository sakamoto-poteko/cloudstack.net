using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateVirtualMachineRequest : APIRequest
    {
        public UpdateVirtualMachineRequest() : base("updateVirtualMachine") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return (string) Parameters[nameof(CustomId).ToLower()]; }
            set { Parameters[nameof(CustomId).ToLower()] = value; }
        }

        /// <summary>
        /// Details in key/value pairs.
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { Parameters[nameof(Details).ToLower()] = value; }
        }

        /// <summary>
        /// user generated name
        /// </summary>
        public string DisplayName {
            get { return (string) Parameters[nameof(DisplayName).ToLower()]; }
            set { Parameters[nameof(DisplayName).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the vm to the end user or not.
        /// </summary>
        public bool? DisplayVm {
            get { return (bool?) Parameters[nameof(DisplayVm).ToLower()]; }
            set { Parameters[nameof(DisplayVm).ToLower()] = value; }
        }

        /// <summary>
        /// group of the virtual machine
        /// </summary>
        public string Group {
            get { return (string) Parameters[nameof(Group).ToLower()]; }
            set { Parameters[nameof(Group).ToLower()] = value; }
        }

        /// <summary>
        /// true if high-availability is enabled for the virtual machine, false otherwise
        /// </summary>
        public bool? HaEnable {
            get { return (bool?) Parameters[nameof(HaEnable).ToLower()]; }
            set { Parameters[nameof(HaEnable).ToLower()] = value; }
        }

        /// <summary>
        /// instance name of the user vm
        /// </summary>
        public string InstanceName {
            get { return (string) Parameters[nameof(InstanceName).ToLower()]; }
            set { Parameters[nameof(InstanceName).ToLower()] = value; }
        }

        /// <summary>
        /// true if VM contains XS/VMWare tools inorder to support dynamic scaling of VM cpu/memory
        /// </summary>
        public bool? IsDynamicallyScalable {
            get { return (bool?) Parameters[nameof(IsDynamicallyScalable).ToLower()]; }
            set { Parameters[nameof(IsDynamicallyScalable).ToLower()] = value; }
        }

        /// <summary>
        /// new host name of the vm. The VM has to be stopped/started for this update to take affect
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the OS type that best represents this VM.
        /// </summary>
        public Guid OsTypeId {
            get { return (Guid) Parameters[nameof(OsTypeId).ToLower()]; }
            set { Parameters[nameof(OsTypeId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional binary data that can be sent to the virtual machine upon a successful deployment. This binary data must be base64 encoded before adding it to the request. Using HTTP GET (via querystring), you can send up to 2KB of data after base64 encoding. Using HTTP POST(via POST body), you can send up to 32K of data after base64 encoding.
        /// </summary>
        public string UserData {
            get { return (string) Parameters[nameof(UserData).ToLower()]; }
            set { Parameters[nameof(UserData).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates properties of a virtual machine. The VM has to be stopped and restarted for the new properties to take effect. UpdateVirtualMachine does not first check whether the VM is stopped. Therefore, stop the VM manually before issuing this call.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse UpdateVirtualMachine(UpdateVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse UpdateVirtualMachine(UpdateVirtualMachineRequest request) => _proxy.Request<UserVmResponse>(request);
    }
}
