using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMVC.Models;

namespace WebMVC.Repository
{
    public class Repositorio
    {
        public static List<Whisky> whiskys = new List<Whisky>();
        public void Create(Whisky model)
        {
            whiskys.Add(model);
        }
        public List<Whisky> Read()
        {
            return whiskys;
        }
        public Whisky Read(int id)
        {
            return whiskys.Find(s => s.Id == id);
        }
        public void Update(Whisky model)
        {
            int index = whiskys.FindIndex(s => s.Id == model.Id);
            whiskys[index] = model;
        }
        public void Delete(int id)
        {
            Whisky model = Read(id);
            if (model != null)
            {
                whiskys.Remove(model);
            }
        }
    }
}