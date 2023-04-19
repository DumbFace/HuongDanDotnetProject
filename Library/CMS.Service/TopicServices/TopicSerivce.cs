using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain;
using CMS.Core.Domain.Topics;
using CMS.Data.EFCore;

namespace CMS.Service.TopicSerivces
{
    public class TopicSerivce : Repository<Topic>, ITopicService 
    {
        
    }
}