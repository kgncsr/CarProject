﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        void Add(Color color);
        void Delete(int colorId);
        void Update(Color color);
        Color GetById(int id);
        List<Color> GetAll();
    }
}