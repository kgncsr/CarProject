using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(int colorId)
        {
            _colorDal.Delete(p => p.ColorID== colorId);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll().ToList();
        }

        public Color GetById(int id)
        {
            return _colorDal.Get(p => p.ColorID == id);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}
