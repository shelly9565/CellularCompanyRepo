﻿using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Infra.Providers.Info
{
    public interface ILineProvider
    {
        Task<IEnumerable<LineDto>> GetAllLines();
        Task<LineDto> GetLine(int id);
        Task<LineDto> AddLine(LineDto lineDto, SelectedNumberDto selectedNumberDto);
        Task<LineDto> UpdateLine(int id, LineDto lineDto);
        Task<LineDto> RemoveLine(int id);
    }
}
