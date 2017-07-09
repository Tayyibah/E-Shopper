using EAD_Project.Models;
using PMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAD_Project.BAL
{
    public class CommentBO
    {
        public static int Save(EAD_Project.PMS.Entities.CommentDTO dto)
        {
            return CommentDAO.Save(dto);
        }

        public static EAD_Project.PMS.Entities.CommentDTO GetCommentById(int pid)
        {
            return CommentDAO.GetCommentById(pid);
        }
        public static List<EAD_Project.PMS.Entities.CommentDTO> GetAllComments()
        {
            return CommentDAO.GetAllComments();
        }


    }
}
