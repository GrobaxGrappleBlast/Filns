using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filns_Interfaces;

namespace Filns_Backend {
    public abstract class AbstractAssortmentManager<T>{


        public List<ISupportFileFormats> _handlers = new List<ISupportFileFormats>();
        public void addHandler(ISupportFileFormats handler){
            _handlers.Add(handler);
        }
        public AbstractAssortmentManager(){}
        public T getHandler(string extension){
            foreach(ISupportFileFormats handler in _handlers) {
                foreach(string ext in handler.supportedExtensions){
                    if(ext == extension)
                        return (T) handler;
                    }
            }
            throw new Exception("File Format "+extension+" Was not supported");
        }

    }
}
