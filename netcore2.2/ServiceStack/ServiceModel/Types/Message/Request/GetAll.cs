﻿using System.Collections.Generic;

namespace ServiceStack.ServiceModel.Types.Message.Request
{
    [Route("/messages", "GET")]
    public class GetAll : IReturn<IReadOnlyList<Message>>
    {
    }
}