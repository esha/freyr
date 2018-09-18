﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class GroupsListRequest1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public GroupsListRequest GroupsListRequest;

        public GroupsListRequest1()
        {
        }

        public GroupsListRequest1(GroupsListRequest groupsListRequest) => GroupsListRequest = groupsListRequest;
    }
}