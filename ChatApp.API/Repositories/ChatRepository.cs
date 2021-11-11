using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatApp.API.DbContext;
using ChatApp.Bussiness.Models;

namespace ChatApp.API.Repositories
{
   public class ChatRepository : IChatRepository
    {
   private readonly ChatAppDbContext _mBDbContext;

        public ChatRepository(ChatAppDbContext mBDbContext)
        {
            _mBDbContext = mBDbContext;
        }

        public Chat AddChat(Chat chat)
        {
            var addChat = _mBDbContext.Chats.Add(chat);
            _mBDbContext.SaveChanges();
            return addChat.Entity;
        }

        public void DeleteChat(int chatId)
        {
            var Chat = _mBDbContext.Chats.FirstOrDefault(e => e.Id == chatId);
            if (Chat == null) return;

            _mBDbContext.Chats.Remove(Chat);
            _mBDbContext.SaveChanges();
        }

        public IEnumerable<Chat> GetAllChats()
        {
            return _mBDbContext.Chats;
        }

        public List<Comment> GetAllCommentsByChat(int chatId)
        {
            var chat = _mBDbContext.Chats.FirstOrDefault(c => c.Id == chatId);

            
            return chat.Comments.ToList();
            

            
        }

        public Chat GetChatbyId(int chatId)
        {
            return _mBDbContext.Chats.FirstOrDefault(c => c.Id == chatId);
        }

        public Chat GetChatbyName(string chatName)
        {
            return _mBDbContext.Chats.FirstOrDefault(c => c.Name == chatName);
        }

        public Chat UpdateChat(Chat chat)
        {
            var updateChat = _mBDbContext.Chats.FirstOrDefault(e => e.Id == chat.Id);

            if (updateChat != null)
            {
                updateChat.Name = chat.Name;
                updateChat.Content = chat.Content;
                updateChat.Comments = chat.Comments;

                _mBDbContext.SaveChanges();

                return updateChat;
            }
            return null;
        }
    }
}
