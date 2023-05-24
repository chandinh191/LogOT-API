using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities;
public class TaxIncome : BaseAuditableEntity
{
    public double? Muc_chiu_thue { get; set; }
    public double? Thue_suat { get; set; }
}
