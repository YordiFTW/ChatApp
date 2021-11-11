using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatApp.Bussiness.Models;

namespace ChatApp.API.Repositories
{
    public interface IChatRepository
    {
        IEnumerable<Chat> GetAllChats();
        List<Comment> GetAllCommentsByChat(int chatId);
        Chat GetChatbyId(int chatId);
        Chat GetChatbyName(string chatName);
        Chat AddChat(Chat chat);
        Chat UpdateChat(Chat chat);
        void DeleteChat(int chatId);
    }
}
