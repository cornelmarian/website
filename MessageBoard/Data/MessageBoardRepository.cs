using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageBoard.Data
{
  public class MessageBoardRepository : IMessageBoardRepository
  {
    MessageBoardContext _ctx;
    public MessageBoardRepository(MessageBoardContext ctx)
    {
      _ctx = ctx;
    }

    public IQueryable<Topic> GetTopics()
    {
      return _ctx.Topics;
    }

    public IQueryable<Reply> GetRepliesByTopic(int topicId)
    {
      return _ctx.Replies.Where(r => r.TopicId == topicId);
    }
  }
}