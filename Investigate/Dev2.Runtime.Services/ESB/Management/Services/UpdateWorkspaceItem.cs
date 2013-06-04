﻿using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Dev2.DynamicServices;
using Dev2.Workspaces;
using Unlimited.Framework;

namespace Dev2.Runtime.ESB.Management.Services
{
    /// <summary>
    /// Update a workspace Item
    /// </summary>
    public class UpdateWorkspaceItem : IEsbManagementEndpoint
    {
        public string Execute(IDictionary<string, string> values, IWorkspace theWorkspace)
        {

            string itemXml;
            string roles;
            string isLocal;

            values.TryGetValue("ItemXml", out itemXml);
            values.TryGetValue("Roles", out roles);
            values.TryGetValue("IsLocalSave", out isLocal);

            bool IsLocalSave = false;

            bool.TryParse(isLocal, out IsLocalSave);

            dynamic xmlResponse = new UnlimitedObject(Resources.DynamicService_ServiceResponseTag);
            if (string.IsNullOrEmpty(itemXml))
            {
                xmlResponse.Error = "Invalid workspace item definition";
            }
            else
            {
                try
                {
                    string cleanXML = itemXml.Replace("&gt;", ">").Replace("&lt;", "<");

                    var workspaceItem = new WorkspaceItem(XElement.Parse(cleanXML));
                    if (workspaceItem.WorkspaceID != theWorkspace.ID)
                    {
                        xmlResponse.Error = "Cannot update a workspace item from another workspace";
                    }
                    else
                    {
                        theWorkspace.Update(workspaceItem, IsLocalSave, roles);
                        xmlResponse.Response = "Workspace item updated";
                    }
                }
                catch (Exception ex)
                {
                    xmlResponse.Error = "Error updating workspace item";
                    xmlResponse.ErrorDetail = ex.Message;
                    xmlResponse.ErrorStackTrace = ex.StackTrace;
                }
            }

            return xmlResponse.XmlString;
        }

        public DynamicService CreateServiceEntry()
        {
            var workspaceItemService = new DynamicService { Name = HandlesType(), DataListSpecification = "<DataList><IsLocalSave/><ItemXml/><Roles/><Dev2System.ManagmentServicePayload ColumnIODirection=\"Both\"></Dev2System.ManagmentServicePayload></DataList>" };

            var workspaceItemAction = new ServiceAction {  Name = HandlesType(), ActionType = enActionType.InvokeManagementDynamicService, SourceMethod = HandlesType()};
            workspaceItemService.Actions.Add(workspaceItemAction);

            return workspaceItemService;
        }

        public string HandlesType()
        {
            return "UpdateWorkspaceItemService";
        }
    }
}
