using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatApp.API.Repositories;
using ChatApp.Bussiness.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly IChatRepository chatRepository;

        public ChatController(IChatRepository chatRepository)
        {
            this.chatRepository = chatRepository;
        }


        [HttpPost]
        [Route("CreateChat/")]
        public IActionResult CreateNewChat(string chatname)
        {
            Chat chat = new Chat();

            chat.Name = chatname;

            Comment comment = new Comment();
            
            chat.Content = "";

            chatRepository.AddChat(chat);

            return Ok(" chat added");
        }

        [HttpPost]
        [Route("DeleteChat/")]
        public IActionResult DeleteChat(string chatname)
        {

            Chat chat = chatRepository.GetChatbyName(chatname);

            chatRepository.DeleteChat(chat.Id);

            return Ok(" chat deleted");
        }

        [HttpGet]
        [Route("AllChats/")]
        public IActionResult ShowAllChats()
        {


            chatRepository.GetAllChats();

            return Ok(chatRepository.GetAllChats());
        }

        [HttpGet]
        [Route("AllComments/")]
        public IActionResult ShowAllCommentsByChat()
        {
            int chatId = 1;         

            return Ok(chatRepository.GetAllCommentsByChat(chatId));
        }

        [HttpPost]
        [Route("CommentSimple/")]
        public IActionResult PostCommentSimple(string comment)
        {


            Chat chat = chatRepository.GetChatbyId(1);

            chat.Content += Environment.NewLine + DateTime.Now.ToString() + " " + comment;

            chatRepository.UpdateChat(chat);

            return Ok(chat.Content);
        }

        [HttpPost]
        [Route("CommentComplex/")]
        public IActionResult PostCommentComplex(string comment)
        {
            int chatId = 5;

            Chat chat = chatRepository.GetChatbyId(chatId);

            Comment commentmodel = new Comment();
            commentmodel.Content = comment;
            commentmodel.Date = DateTime.Now;
            commentmodel.UserName = "Yordi";

           
            if (chat.Comments == null)
            {

                chat.Comments = new List<Comment>();
                chat.Comments.Add(commentmodel);
            }
            else
            {
                chat.Comments.Add(commentmodel);
            }


            
            

            chatRepository.UpdateChat(chat);

            return Ok(chat.Comments);
        }

    }
}
